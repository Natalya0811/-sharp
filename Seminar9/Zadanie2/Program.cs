﻿// Задайте значения M и N. Напишите программу, которая которая найдет сумму 
// натуральных элементов в промежутке от M до N.


Console.Write("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Result(m, n);

void Result(int m, int n)
{
    Console.WriteLine(Sum(m - 1, n));
}


int Sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
}