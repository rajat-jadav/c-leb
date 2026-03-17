using System;

class employee
{
    int id;
    string name;
    int salary;

    public employee()
    {
        name = "Rajat";
        id = 1;
        salary = 100000;
    }

    public employee(int i, string n, int s)
    {
        name = n;
        id = i;
        salary = s;
    }

    public int anu_sal()
    {
        return salary*12;
    }

    public void display()
    {
        Console.WriteLine($"hello {name}");
        Console.WriteLine($"ID : {id}");
        Console.WriteLine($"Salary : {salary}");
        int asal = anu_sal();
        Console.WriteLine($"Anual salary : {asal}");
    }
}

class project
{
    public static void Main()
    {
        employee e1 = new employee();
        e1.display();
        employee e2 = new employee(2,"Devang",200);
        e2.display();
    }
}