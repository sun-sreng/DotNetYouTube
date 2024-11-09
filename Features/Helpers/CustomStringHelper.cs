namespace Features.Helpers;

public class CustomStringHelper
{
    private readonly Func<string, string> _reverseFunc;

    public CustomStringHelper()
    {
        _reverseFunc = x=>new string(x.Reverse().ToArray());
    }

    public CustomStringHelper(Func<string, string> reverseFunc)
    {
        _reverseFunc = reverseFunc;
    }

    public string Reverse(string input)
    {
        return _reverseFunc(input);
    }
}

// ReverseString
// Input: "Hello World!"
// Output: !dlroW olleH

// using Features.Helpers;
// using Features.Services;
//
// const string input = "Hello, World! hhh";
// // Console.WriteLine($"Input: {input}, Output: {StringService.ReverseString(input)}");
// // Console.WriteLine($"Input: {input}, Output: {input.Reverse()}");
// var helper = new CustomStringHelper();
// Console.WriteLine(helper.Reverse(input));
//
// var helpers = new CustomStringHelper(x => new string(x.Where(c => !char.IsWhiteSpace(c)).Reverse().ToArray()));
// Console.WriteLine(helpers.Reverse(input));