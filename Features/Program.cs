// ReverseString
// Input: "Hello World!"
// Output: !dlroW olleH

using Features.Extensions;
using Features.Services;

string input = "Hello, WOrld!";
Console.WriteLine($"Input: {input}, Output: {StringService.ReverseString(input)}");
Console.WriteLine($"Input: {input}, Output: {input.Reverse()}");
