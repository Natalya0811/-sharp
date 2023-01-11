// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    int a = num / 10000;
    int b = num %10000;
    int c = num %100;
    int d = num %10;

    if (a == d | b == c)
    {
        Console.WriteLine("Число является палиндромом");
    }

    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
