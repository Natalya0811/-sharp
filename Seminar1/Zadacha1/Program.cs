// Напишите программу, которая на вход принимает два числа, и выдает, какое число большее, а какое меньшее
// a=5, b=7, max=7

Console.WriteLine("Введите первое число");

int a =Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите второе число");

int b =Convert.ToInt32 (Console.ReadLine());

if (a>b) Console.WriteLine ($"max {a}");
else Console.WriteLine ($"max {b}");
