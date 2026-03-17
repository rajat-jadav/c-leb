using System;

class student
{
    int rollno;
    string name;
    int marks;

    public student()
    {
        name = "Rajat";
        rollno = 1;
        marks = 100;
    }

    public student(int rn,string n,int mr)
    {
        name = n;
        rollno = rn;
        marks = mr;
    }

    public char grade()
    {
        if(marks == 100)
        {
            return 'A';
        }
        else if (marks >= 80 && marks < 100)
        {
            return 'B';
        }
        else if (marks >= 60 && marks < 80)
        {
            return 'C';
        }
        else 
        {
            return 'F';
        }
    }

    public void display()
    {
        Console.WriteLine($"You'r name : {name}");
        Console.WriteLine($"Roll No. : {rollno}");
        Console.WriteLine($"Marks : {marks}");
        char g = grade();
        Console.WriteLine($"Grade : {g}");
    }
}

class project
{
    public static void Main()
    {
        student s1 = new student();
        s1.display();

        student s2 = new student(1,"Arav",80);
        s2.display();

    }
}

