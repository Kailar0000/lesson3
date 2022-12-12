
Console.Clear();
Console.Write("Введите число: ");
string? number = Console.ReadLine();
int i = 0;
int N = number.Length;
int n = N;
bool x = true;

while( i < n && x == true)
{
    if(number[i] != number[n])
    {
        x = false;
    }
    i ++;
    n = N - i;
}
if(x == true)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
