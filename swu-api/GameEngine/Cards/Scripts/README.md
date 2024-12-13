# Card Utility Scripts
This directory contains two scripts for helping with adding new card implementations to the code base.
## build_mapping_by_set.py
This script is used to create default mappings for all of the cards in a set. The set abbreviation is passed in as param. The script then reaches to [swudb.com](https://swudb.com) to generate the mapping. The default mapping throws a `NotImplementedException` for all cards in the set. This will currently work for set 1, but will need some adjustments for future sets to ignore reprints.
## build_base_card.py
This script is used to create a default .NET class for a card. It reaches out to [swudb.com](https://swudb.com) to get the card type, cost, name, etc to build the file. It will create the file directory by set abbreviation and card type.
# Script setup
## Windows
```powershell
PS C:\star-wars-unlimited\swu-api\GameEngine\Cards\Scripts> pip install virtualenv
PS C:\star-wars-unlimited\swu-api\GameEngine\Cards\Scripts> py -m venv .venv
PS C:\star-wars-unlimited\swu-api\GameEngine\Cards\Scripts> .\.venv\Scripts\activate
(.venv) PS C:\star-wars-unlimited\swu-api\GameEngine\Cards\Scripts> pip -r .\requirements.txt
```
## Unix
```bash
user@user:/star-wars-unlimited/swu-api/GameEngine/Cards/Scripts$ pip3 install virtualenv
user@user:/star-wars-unlimited/swu-api/GameEngine/Cards/Scripts$ python3 -m venv .venv
user@user:/star-wars-unlimited/swu-api/GameEngine/Cards/Scripts$ source .venv/bin/activate
(.venv) user@user:/star-wars-unlimited/swu-api/GameEngine/Cards/Scripts$ pip3 install -r requirements.txt
```
