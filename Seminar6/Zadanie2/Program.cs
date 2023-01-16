// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
// y =k1*x + b1, y=k2*x + b2; значения задаются пользователем


Console.WriteLine("Введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine("Координаты точки перечения двух прямых :");
    Console.WriteLine($"{x};{y}");
}
else if (b1 == b2) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые параллельны");

