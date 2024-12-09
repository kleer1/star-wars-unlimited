import argparse
import bs4
import requests
from requests.adapters import HTTPAdapter
from urllib3.util.retry import Retry
import sys
import os
import re

parser = argparse.ArgumentParser("build_mapping_by_set")
parser.add_argument("set", help="Set abbreviation. Example 'sor' for 'Spark of Rebellion'")
parser.add_argument("--numbers", '-n', help="Card numbers within the set. Requires 3 digits per number. Example '-n 010 123 008'", nargs='+', required=True)
parser.add_argument('--dryRun', '-d', action='store_true')
parser.add_argument('--verbose', '-v', action='store_true')
args = parser.parse_args()
dry_run = args.dryRun
verbose = args.verbose
numbers = args.numbers

session = requests.Session()
retry = Retry(connect=3, backoff_factor=0.5)
adapter = HTTPAdapter(max_retries=retry)
session.mount('http://', adapter)
session.mount('https://', adapter)

for number in numbers:
    if len(number) != 3:
        print(f'Skipping {number} due to invalid format. Requires 3 digits per card number.')
        continue
    print(f'Bulding card implementation for {args.set}_{number}')
    base_url = f"https://swudb.com/card/{args.set.lower()}/{number}"
    response = session.get(base_url)

    soup = bs4.BeautifulSoup(response.text, 'html.parser')
    info_div = soup.find('div', {'class': 'card-info-box'})
    card_stats_divs = info_div.find_all('div', {'class' : 'card-stats-row'})
    if len(card_stats_divs) < 3:
        print(f'Unexpected output from Swudb. Expected at least 3 card-stats-row. Received {len(card_stats_divs)}')
        sys.exit()

    # first div has the name, uniqye symbol, and title
    name_header = card_stats_divs[0].find('h4')
    if name_header:
        name = name_header.text.strip()
        is_unique = False
        if name.startswith('⟡ '):
            is_unique = True
            name = name.removeprefix('⟡ ')
    else:
        print("Could not parse card name from swudb")
        sys.exit()

    title_span = card_stats_divs[0].find('span', {'class': 'card-title'})
    title = ''
    if title_span:
        title = title_span.text.strip()

    # second div has the aspects, cost, card type and arena
    aspect_imgs = card_stats_divs[1].find_all('img', {'class' : 'card-stats-aspect'})
    aspects = []
    if aspect_imgs:
        for img in aspect_imgs:
            if img['alt']:
                aspects.append(img['alt'].split()[0])

    cost_div = card_stats_divs[1].find('div', {'title': 'Cost'})
    if cost_div:
        cost = cost_div.text.strip()

    pb1_div = card_stats_divs[1].find('div', class_='pb-1')
    card_type_span = pb1_div.find('span') if pb1_div else None
    if card_type_span:
        card_type = card_type_span.text.strip()
    else:
        print("Could not parse card type from swudb")
        sys.exit()
    arena_div = card_stats_divs[1].find('div', class_='card-stats-arena-box')
    arena_span = arena_div.find('span') if arena_div else None
    arena = ''
    if arena_span:
        arena = arena_span.text.strip()

    # third div has card ability. not using this for anything currently. this will have to be implemented manually
    # fourth div is artist info

    # get stats and traits as applicable
    stats_div = info_div.find('div', {'class': 'card-stats-unit-row'})
    power_span = stats_div.find('span', {'class': 'card-power'})
    power = ''
    if power_span:
        power = power_span.text.replace('+', '').strip()
    hp_span = stats_div.find('span', {'class': 'card-hp'})
    hp = ''
    if hp_span:
        hp = hp_span.text.replace('+', '').strip()
    traits_as = stats_div.find_all('a')
    if traits_as:
        traits = []
        for trait in traits_as:
            traits.append(trait.text.strip().replace(' ', '').replace('\xa0', ''))

    class_name = name.replace(' ', '')
    # Ensure the name follows .NET class name rules:
    # 1. Remove invalid characters for .NET class names (only letters, digits, and underscores are allowed)
    class_name = re.sub(r'[^A-Za-z0-9_]', '', class_name)
    if not class_name:
        print('Could not convert card name to a valid .NET class name')
        sys.exit()
    # 2. If the name starts with a digit, prepend an underscore (so it's a valid class name)
    if class_name[0].isdigit():
        class_name = "_" + class_name

    class_aspects = ", ".join(f"Aspect.{aspect}" for aspect in aspects) if aspects else ''
    class_traits = ", ".join(f"Trait.{trait}" for trait in traits) if traits else ''
    if card_type == 'Leader':
        class_inherit = f"{'Deployable' if arena else ''}{card_type}"
    else:
        class_inherit = f"{arena if arena else ''}{card_type}"
    class_namespace = f"{args.set.upper()}.{card_type}s"
    card_name = f"{name}{', title' if title else ''}"
    file_name = f"{class_name}.cs"

    dotnet_file = f'''using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.{class_namespace}
    {{
        internal class {class_name} : {class_inherit}
        {{
            public {class_name}() : base("{card_name}"{f', {cost}' if cost else ''}{f', {power}' if power else ''}{f', {hp}' if hp else ''}) {{ }}

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> {{ {class_aspects} }};
    {'\n\t\tpublic static bool IsUnique => true;\n' if is_unique and card_type != 'Leader' else ''}
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() {{ {class_traits} }};
        }}
    }}
    '''
    if verbose:
        print(dotnet_file)

    # save the new file to the dotnet project
    current_directory = os.path.dirname(os.path.abspath(__file__))
    root_directory = os.path.abspath(os.path.join(current_directory, '..'))
    namespace_path = os.path.join(root_directory, *class_namespace.split('.'))
    os.makedirs(namespace_path, exist_ok=True)
    file_path = os.path.join(namespace_path, file_name)
    print(file_path)

    if not dry_run:
        with open(file_path, "w") as f:
                f.write(dotnet_file)
        print(f"File saved to: {file_path}")

    # adjust the card mapping to show the card has been implemented
    root_directory = os.path.abspath(os.path.join(current_directory, '../..'))
    mappings_path = os.path.join(root_directory, 'Utils/SwudbMappingUtil.cs')

    with open(mappings_path, 'r') as file:
        lines = file.readlines()

    mappsing_key = f"{args.set.upper()}_{number}"
    for i, line in enumerate(lines):
        if mappsing_key in line:
            new_text = f'() => new Cards.{args.set.upper()}.{card_type}s.{class_name}()'
            old_text = '() => throw new NotImplementedException()'
            if verbose:
                print(f'mapping replacement:\n\tOld text: {old_text}\n\tNew text: {new_text}')
            lines[i] = lines[i].replace(old_text, new_text)
            break

    if not dry_run:
        with open(mappings_path, 'w') as file:
            file.writelines(lines)  # This writes the lines back to the file
        print(f"Updated mappings.")

    # check if the traits need to be added to the enum
    root_directory = os.path.abspath(os.path.join(current_directory, '..'))
    enum_trait_path = os.path.join(root_directory, 'Trait.cs')

    if verbose:
        print(f'Enum path: {enum_trait_path}')

    with open(enum_trait_path, 'r') as file:
        enum_content = file.readlines()

    if verbose:
        print(enum_content)
    # Find the start and end of the enum definition
    enum_start = None
    enum_end = None
    for i, line in enumerate(enum_content):
        if "enum" in line:  # Start of the enum
            enum_start = i + 1
        if enum_start is not None and "}" in line:  # End of the enum
            enum_end = i
            break
    if verbose:
        print(f'enum start: {enum_start}, enum end: {enum_end}')

    if enum_start is None or enum_end is None:
        raise ValueError("Could not find a valid enum definition in the file.")

    enum_members = [
        line.strip().strip(",")  # Remove whitespace and trailing comma
        for line in enum_content[enum_start + 1:enum_end]
        if line.strip() and not line.strip().startswith("//")  # Ignore comments and blank lines
    ]

    missing_traits = []
    for trait in traits:
        if trait not in enum_members:
            missing_traits.append(trait)
            enum_content.insert(enum_end, f"\t\t{trait},\n")
            enum_end = enum_end + 1

    if not dry_run:
        # Write the updated enum back to the file
        with open(enum_trait_path, 'w') as file:
            file.writelines(enum_content)

    print(f"Traits '{missing_traits}' added to the enum in {enum_trait_path}.")