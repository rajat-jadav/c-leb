//posetive and negative in array

int[] arr = new int[5];
int pos = 0;
int neg = 0;
int zero = 0;

for(int i = 0; i < arr.Length; i++)
{
    Console.Write("Enter "+(i+1)+" value : ");
    arr[i] = int.Parse(Console.ReadLine());
    
    if(arr[i] > 0)
    {
        pos++;
    }
    else if(arr[i] < 0)
    {
        neg++;
    }
    else
    {
        zero++;
    }
}

Console.WriteLine("Positive numbers: " + pos);
Console.WriteLine("Negative numbers: " + neg);
Console.WriteLine("Zeros: " + zero);