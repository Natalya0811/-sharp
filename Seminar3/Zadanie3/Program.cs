﻿// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<= x; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}