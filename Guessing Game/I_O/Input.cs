using Guessing_Game.Validation;

namespace Guessing_Game.I_O;

static class ConsoleInput 
{

    public static int ReadInteger(string message)
    {
        int integer;
        do{
            Console.WriteLine(message);
        }while(!Validator.IsValidInteger(Console.ReadLine(), out integer));

        return integer;
    }
}