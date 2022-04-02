// Показать числа Фибоначчиee
Console.WriteLine("Сколько чисел Фибонначи вывести в консоль?");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int sum = 0;
int first = 1;
int second = 1;
while (i <= number)
{
    if(i == 1 || i == 2) 
    {
        Console.Write("1 ");
        i++;
    }
    else
    {
        sum = first + second;
        Console.Write(sum + " ");
        first = second;
        second = sum;
        i++;
    }
}
