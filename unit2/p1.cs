//max from 5 inputed value

int[] num = new int[5];
int max = num[0];
for (int i = 0; i < num.Length; i++)
{
    Console.Write("Enter a number: ");
    num[i] = int.Parse(Console.ReadLine("Enter "+(i+1)+" Value: "));
}

for (int i = 0; i< num.Length; i++)
{
    if(num[i] > max)
    {
        max = num[i];
    }
}

Console.WriteLine("The maximum value is: " + max);