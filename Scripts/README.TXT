1. Using the MainMenu.cs script you can switch between the scenes by using a Unity Button
2. Using CharacterBase.cs you can create very quickly different characters with their own personalized stats and lists of moves
3. Character.cs is used to store the stats for every separate character and to manage their level and moves
4. MoveBase.cs is used to creade very quickly different moves with their own stats
5. Move.cs move is used to control the stats of created moves
6. BattleDialogueBox.cs is used to control various text elements used in the unity UI for the game.
7. BattleUnit.cs is used to create a player or enemy unity on the interface and selects the correct sprite accordingly.
8. BattleHud.cs is used for switching the base stats on the HUD and updating them accordingly
9. HPBar.cs is used for controlling the HPBar of both the player and the enemy and lowering it smoothly according to the damage taken.
10.BattleSystem.cs is used for controlling the flow of the battle by managing the moves, of both the player and the enemy, checking the status of the battle 
   and whether they depleted their hp. It is also handles input from the player so they could control the hud and pick various moves.