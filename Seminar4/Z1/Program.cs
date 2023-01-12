// Напишите программу, которая принимает на вход два числа (A и B), 
// и возводит число A в натуральную степень В

Console.WriteLine("Введите первое число");
int a =Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
int b =Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ($"Первое число в натуральной степени второго равно {S(a,b)}");

int S(int a, int b)

{
    int result=1;
    for ( int i=1; i < b ; i++)
    result = result*a;
}
return S;