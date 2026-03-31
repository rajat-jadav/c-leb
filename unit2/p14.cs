//Definition : Write a program to implement an interface called with a method Pass(int mark) that returns a boolean value. 
//Write another interface called with a method Division(int average) that returns a String. 
//Create a class called which implements both the and interfaces. The Pass method should return if the mark is greater than or equal to 50, 
//otherwise it should return .

using System;

public interface IPass
{
    bool Pass(int mark);
}

public interface IDivision
{
    string Division(int average);
}

public class StudentResult : IPass, IDivision
{
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else
            return "Fail";
    }
}

public class Program
{
    public static void Main()
    {
        StudentResult student = new StudentResult();
        
        // Test Pass method
        Console.WriteLine("Mark 75: " + student.Pass(75));  // Output: True
        Console.WriteLine("Mark 45: " + student.Pass(45));  // Output: False
        Console.WriteLine("Mark 50: " + student.Pass(50));  // Output: True
        
        // Test Division method
        Console.WriteLine("Average 65: " + student.Division(65));  // Output: First Division
        Console.WriteLine("Average 55: " + student.Division(55));  // Output: Second Division
        Console.WriteLine("Average 45: " + student.Division(45));  // Output: Fail
    }
}