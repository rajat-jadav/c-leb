//armstrong number

Console.Write("Enter number : ");
int num = int.Parse(Console.ReadLine());
int temp = num;
int p = 0;
int i = 0;
int res = 0;

while(temp != 0)
{
    p++;
    temp /= 10;
}

temp = num;

while(temp != 0)
{
    i = temp % 10;
    res += (int)Math.Pow(i, p);
    temp /= 10;
}

if(res == num)
{
    Console.WriteLine("Armstrong number");
}
else
{
    Console.WriteLine("Not an Armstrong number");
}