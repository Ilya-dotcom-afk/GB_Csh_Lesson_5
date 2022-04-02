// Показать числа Фибоначчи
Console.WriteLine("количество");
int number = Convert.ToInt32(Console.ReadLine());
int first = 1;
int second = 1;

int Fib (int n, int f, int s)
{
    if (n > 1)
    {
        Console.Write(f + " ");
        return Fib(n-1, s, f+s);
    }
return f;
}
Console.WriteLine(Fib(number, first, second));