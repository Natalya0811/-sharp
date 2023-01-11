// Напишите программу, которая принимает на вход координаты двух точек ,
// и находит расстояние между ними в 3D пространстве


Console.WriteLine("Введите координату x первой точки!");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки!");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки!");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки!");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки!");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки!");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Dist(x1,y1,z1,x2,y2,z2));

// AB = √ (x2-x1)2 + (y2-y1)2 + (z2-z1)2

double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return D;
}