# TODOs
1. **GameEngine**
   * Main idea of how the GameEngine will work:
     1. The GameEnine will encapsulate a single game of star wars unlimited. I made something similar for the [Star Wars Deckbuidling game](https://github.com/kleer1/swdb/blob/main/Game/SWDBGame.cs). Don't feel the need to follow it exactly. It wasn't build to be used with a UI and was made for a different game, but could be a template for how to do it.
     2. It will have an `Initialize()` method that will finish setting everything up and return the initial `GameState`.
        * The `GameState` will have a the know game state for each player (what is in a deck/opponent's hand will be absent). It will also have the Id of the current player and a list of valid actions that player can take. This `Action` object should also represent the number of choices associated with the action and all of the card Ids that are valid choices. Example: If it is an attack action there would be two nested choices. First would be selecting the unit to attack with and thesecond would be the base or unit to attack. The front end can then use these Ids to force to user to only select valid actions. 
     4. It will have an `ApplyAction()` method that will be called after the user has selected the action they want to use and all correpsonding choices. The `GameEngine` should still double check that what it receives is valid (never trust user input). It will then apply the choice to the game and return the next `GameState`. In order to speed the application of the action, we'll probably want a dictionary of Id to card so that we can look up any card by its Id instead of having to search the game state for it. 
     5. It will also need to decide if the game is over and return that somehow after an action is applied.
   * In order to finish the `GameEngine` implementation, there will  need to be some more interfaces and functionality added to the cards. For instance, we will probably want something like a `IHasAbility` interface that can be appiled to a card. The interface would probably have methods like `IsAbilityActive()` and `ApplyAbility()` so that the `GameEngine` can determine what cards have abilites that can be used in the current state. Also maybe `IAbilityHasTargets` with a `GetValidTargets()` method for getting the list of cards the card can target. The `GameEngine` could then do something like:
      ```csharp
      if (typeof(card) == IHasAbility && ((IHasAbility)card).IsAbilityActive())
      {
          listOfActiveAbilities.Add(card.Id);
      }
      ```
   * _Stretch Goals_
    1. Long term may want to consider having the engine export its state so that it can persisted somewhere (redis, sql, ?) and then allow a game to resumed from state export. This would allow games to be resumed after a server crash. Not a necessity, but something to consider when developing.
    2. As part of the above, may want to consider keeping all of the states around to allow replays.
2. **GameHub**
   * The `GameHub` will be the bridge between the game running on the backend and the frontend representation. It will use [signalR](https://learn.microsoft.com/en-us/aspnet/signalr/overview/getting-started/introduction-to-signalr) to communicate the game state to each player. Either this class or another class it uses will need to hold a reference to every game that is in process so that when the frontend sends a player action to the hub it can find the correct game and apply the action for the player.
3. **Frontend Game UI**
   * We'll need to create views and components in the ui part of the repo. They will need to register with the `GameHub` so that they can send and receive updates. UI is not my speciality, so if you want to learn UI, please feel free to take thos over.
   * This should also have a chat component so that players can talk to each other and both players actions should be logged into the chat.
4. **Lobby and Game Creation**
   * Need the backend and frontend work to support matchmaking and deck selction. I've started the wotk for taking a swudb.com deck link and converting it to an internal deck object. But none of the other matchmaking has been started.
   * Not a requirement, but there is often a global chat in the lobby for this kind of site.
5. **Admin controls**
   * We'll probably want some admin functionality for super users. Haven't thought this out all of the way, but maybe ban or invite functions. Unitl we decide if this gets rolled out publicly, we'll probably only want users to be able to create an account with an invite code, email, or something.
6. **Authentication**
   * We'll need account creation, authentication, and login functionality. There are lots of tutorials and libraries out there for doing this with .NET, next.js, and signalR. 
