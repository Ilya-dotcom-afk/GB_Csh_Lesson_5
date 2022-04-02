//Показать числа Фибоначчи
Console.WriteLine("До какого числа считать последовательность Фибоначчи");
int n = Convert.ToInt32(Console.ReadLine());
int first = 1;
int second = 1;
Console.Write(first + " " + second + " ");
  while (n >= first + second)
  {
      int sum =  first + second;
      Console.Write(sum + " ");
        first = second;
        second = sum;
  }