// Напишите программу, которая принимает на вход число,
// и выдает сумму цифр в числе

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе равна {Result(a)}");


int Result(int a)

{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}