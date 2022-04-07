// Написать программу масштабирования фигуры. Тут для тех кто далеко улетел, чтобы задавались 
//вершины фигуры списком (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)" коэффициент
// масштабирования k задавался отдельно - 2 или 4 или 0.5. В результате показать координаты,
// которые получатся.при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
using System.Linq;
Console.WriteLine("Введите целочисленный коэффициент масштабирования");
int k = Convert.ToInt32(Console.ReadLine());
string text = "(0,0) (2,0) (2,2) (0,2)"
                .Replace("(", "")
                .Replace(")", "");
var date = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Select(point => (point.x *k, point.y * k))
                .ToArray();

for (int i = 0; i < date.Length; i++)
{
    
        Console.WriteLine(date[i]);
    
    
}

