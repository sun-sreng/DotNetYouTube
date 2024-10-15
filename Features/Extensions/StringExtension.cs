namespace Features.Extensions;

public static class StringExtension
{
    public static string Reverse(this string input)
    {
        return new string(input.ToCharArray().Reverse().ToArray());
    }
}
