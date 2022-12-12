Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int x = 1; x <= N; x++)
Console.Write($"{Math.Pow(x, 3)}; ");