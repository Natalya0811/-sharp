// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1.

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
Result(n, count);


void Result(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        Result(n, count + 1);
        Console.Write(count + " ");
    }
}
