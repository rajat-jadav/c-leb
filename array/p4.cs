//sum and average

int[] arr = new int[5];
int sum = 0;
for(int i = 0; i < arr.Length; i++)
{
    Console.Write("Enter " + (i + 1) + " value : ");
    arr[i] = int.Parse(Console.ReadLine());

    sum += arr[i];
}

double average = (double)sum / arr.Length;
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Average: " + average);