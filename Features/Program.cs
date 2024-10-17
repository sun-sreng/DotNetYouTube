// ReverseString
// Input: "Hello World!"
// Output: !dlroW olleH

using Features.Helpers;

string input = "Hello, WOrld!";
// Console.WriteLine($"Input: {input}, Output: {StringService.ReverseString(input)}");
// Console.WriteLine($"Input: {input}, Output: {input.Reverse()}");
var helper = new CustomStringHelper();
Console.WriteLine(helper.Reverse(input));