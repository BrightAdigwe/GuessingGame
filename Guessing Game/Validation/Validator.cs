namespace Guessing_Game.Validation;

static class Validator
{
    public static bool IsValidInteger(string? value, out int integer)
    {
        return int.TryParse(value, out integer);
    }
}