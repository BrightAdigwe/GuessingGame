namespace Guessing_Game.Game;

public class Dice
{
    private const int SidesCount = 6;
    
    private readonly Random _random; 

    public Dice()
    {
        _random = new Random();
    }

    public int Roll() =>  _random.Next(1, SidesCount + 1);
}

