using System;

class Program
{
    static void Main()
    {
        double billAmount, discount = 0;
        string category;

        Console.Write("Enter bill amount: ");
        billAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter customer category (senior / regular / industrial): ");
        category = Console.ReadLine().ToLower();

        if (category == "senior")
        {
            discount = billAmount * 0.20;
        }
        else if (category == "regular")
        {
            discount = billAmount * 0.10;
        }
        else if (category == "industrial")
        {
            discount = billAmount * 0.30;
        }
        else
        {
            Console.WriteLine("Invalid category");
            return;
        }

        double finalBill = billAmount - discount;

        Console.WriteLine("Original Bill: " + billAmount);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Bill: " + finalBill);
    }
}