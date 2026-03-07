//min from 5 inputed value
using System;
class program
{
    static void Main()
    {

        int[] num = new int[5];
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("Enter a number: ");
            num[i] = int.Parse(Console.ReadLine());
        }

        int min = num[0];
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
            }
        }

        Console.WriteLine("The minimum value is: " + min);
    }
}