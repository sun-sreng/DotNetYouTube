namespace Features.Services;

public static class StringService
{
    public static string ReverseString(string input)
    {
        return new string(input.ToCharArray().Reverse().ToArray());
    }

    public static string FindTheMostUsedCharacter(string input)
    {
        var mostUsedChar= input.ToLower().GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key.ToString();
        return mostUsedChar;
    }
}
