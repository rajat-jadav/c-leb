using System;

int pin = 123;
int entpin;
int balance = 999999;
int entbala;

Console.Write("Enter pin : ");
entpin = int.Parse(Console.ReadLine());

if (entpin == pin)
{
    Console.WriteLine("Correct pin");
    Console.WriteLine("Enter amount : ");
    entbala = int.Parse(Console.ReadLine());
    if (entbala <= balance)
    {
        Console.WriteLine("Withdrawal successful");
        balance -= entbala;
        Console.WriteLine("Remaining balance: " + balance);
    }
    else
    {
        Console.WriteLine("Insufficient funds");
    }
}
else
{
    Console.WriteLine("Wrong pin");
}