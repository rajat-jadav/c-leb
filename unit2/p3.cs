using System;

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int temp= num;
int rev = 0;

while(num != 0)
{
    rev = rev * 10 + num % 10;
    num /= 10;
}

if(temp == rev)
{
    Console.WriteLine("The number is palindrome");
}
else
{
    Console.WriteLine("The number is not palindrome");
}