import argparse
import bs4
import pandas as pd
from io import StringIO
import requests
from requests.adapters import HTTPAdapter
from urllib3.util.retry import Retry
from urllib.parse import urlencode

parser = argparse.ArgumentParser("build_mapping_by_set")
parser.add_argument("set", help="Set abbreviation. Example 'sor' for 'Soark of Rebellion'", type=str)
parser.add_argument("output", help="File to output to.", type=str)
args = parser.parse_args()

session = requests.Session()
retry = Retry(connect=3, backoff_factor=0.5)
adapter = HTTPAdapter(max_retries=retry)
session.mount('http://', adapter)
session.mount('https://', adapter)

base_url = f"https://swudb.com/search/set%3D{args.set}"
page = 1
while page < 7:
    params = { "display" : "checklist", "forceSearch" : "True", "pagenumber" : str(page)}
    query_string = urlencode(params)
    url = f"{base_url}?{query_string}"
    print(url)
    response = session.get(url, allow_redirects=False)
    page = page + 1
    # Check the status code
    if response.status_code != 200:
        break

    soup = bs4.BeautifulSoup(response.text, 'html.parser')
    tables = soup.find_all('table')
    for t, table in enumerate(tables):
        dfs = pd.read_html(StringIO(str(table)))
        for df in dfs:
            for index, row in df.iterrows():
                if row['No'] < 10:
                    num = '00' + str(row['No'])
                elif row['No'] < 100:
                    num = '0' + str(row['No'])
                else:
                    num = str(row['No'])
                with open(args.output, "a+", encoding="utf-8") as f:
                    f.write('{ "' + row['Set'] + '_' + num + '", () => throw new NotImplementedException() }, // ' + row['Name'] + "\n")