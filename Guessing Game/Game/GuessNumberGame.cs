using Guessing_Game.I_O;

namespace Guessing_Game.Game;

class GuessNumberGame
{
    private const int MAXIMUMTRIES = 3;
    private readonly string newLine = Environment.NewLine;

    private readonly Dice _die;

    public GuessNumberGame(Dice die)
    {
        _die = die;
    }

    public GameOutcome Play()
    {   
        int dieOutcome = _die.Roll();

        Console.WriteLine($"A die rolled. Guess the outcome. You have {MAXIMUMTRIES} tries.");
        
        int remainingTries = MAXIMUMTRIES;

        while(remainingTries > 0)
        {
            int guess = ConsoleInput.ReadInteger("Enter a number");

            if(guess == dieOutcome)
            {
                return GameOutcome.Win;
            }
            Console.WriteLine("Wrong number.");
            remainingTries--;
        }

        return GameOutcome.Loss;
    }

    public static void PrintResult(GameOutcome outcome)
    {
         Console.WriteLine((outcome == GameOutcome.Win 
         ? "You win" 
         : "You lose :(") + $"{Environment.NewLine}Enter any key to exit..");
    }
}