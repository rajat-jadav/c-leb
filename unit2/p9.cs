using System;

class Rectangle
{
    int length, width;

    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    public Rectangle(int l, int w)
    {
        length = l;
        width = w;
    }

    public int FindArea()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + FindArea());
    }
}

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle();
        Console.WriteLine("Rectangle 1:");
        r1.Display();

        Console.WriteLine();

        Rectangle r2 = new Rectangle(8, 4);
        Console.WriteLine("Rectangle 2:");
        r2.Display();
    }
}