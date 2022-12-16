//Inovations in C# 11: List Patterns 

// Example: 1
string[] forEmpty = Array.Empty<string>();
string[] forName = new[] { "Alexander" };
string[] forFullName = new[] { "Alexander", "Medved" };
string[] forDefault = new[] { "Alexander", "Medved", "blablabla" };

string CheckList(string[] list) => list switch
{
    [] => "Is empty",
    [string name] => $"My name is: {name}",
    [string firstName, string lastName] => $"My full name is: {firstName}, {lastName}",
    _ => "Default"
};

Console.WriteLine(CheckList(forEmpty));// Is empty
Console.WriteLine(CheckList(forName));// My name is: Alexander
Console.WriteLine(CheckList(forFullName));// My full name is: Alexander, Medved
Console.WriteLine(CheckList(forDefault));// Default

// Example: 2
int[] numbers = { 1, 2, 3 };

Console.WriteLine(numbers is [1, 2, 5]);// false
Console.WriteLine(numbers is [1, 2, 3]);// true
Console.WriteLine(numbers is [1, 2, 3, 4]);// false
Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);//true

if (numbers is [_, var second, _])
{
    Console.WriteLine(second);// 2
}

if (numbers is [var first, .. var rest])
{
    Console.WriteLine(first);// 1
    foreach (var r in rest) Console.WriteLine(r);// 2, 3
}
