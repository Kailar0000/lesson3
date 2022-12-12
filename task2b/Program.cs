
Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[N];
int i = 0;
int max = 0;
while(i < N)
{
    Console.Write($"на {i+1}-ом кусте выросло: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    i = i + 1;
}
max = numbers[N] + numbers[i]+ numbers[i+1]; //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.?
for(i = 1; i < N-1 ; i++)
{
    if(max < numbers[i-1] + numbers[i]+ numbers[i+1])
        max = numbers[i-1] + numbers[i]+ numbers[i+1];
}

if(max<numbers[N] + numbers[0]+ numbers[N-1])
    max = numbers[N] + numbers[0]+ numbers[N-1];

Console.Write(max);