using System;
using System.Linq;

Console.WriteLine("Enter a string: ");
string str = Console.ReadLine();
string rev = new string(str.Reverse().ToArray());

if(str == rev)
{
    Console.WriteLine("String is palindrome");
}
else
{
    Console.WriteLine("String is not palindrome");
}