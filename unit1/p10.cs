using System;

Console.Write("Enter a number : ");
int num = int.Parse(Console.ReadLine());
int fect = 1;
while(num > 0)
{
    fect *= num;
    num--;
}

Console.WriteLine($"Fectorial of given value is {fect}");