namespace Features.Services;

public static class StringService
{
    public static string ReverseString(string input)
    {
        return new string(input.ToCharArray().Reverse().ToArray());
    }
}
