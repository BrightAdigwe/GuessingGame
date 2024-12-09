using Guessing_Game.Game;

Dice die = new();
GuessNumberGame game = new(die);

GameOutcome gameOutcome = game.Play();

GuessNumberGame.PrintResult(gameOutcome);
       
Console.ReadKey();
