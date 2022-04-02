// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Введите коэффициент k1 для первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1  для первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2 для второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2  для второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;
Console.Write("(" + x + ";" + y + ")");