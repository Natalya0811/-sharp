﻿// Напишите программу, которая на вход принимает число и выдает, является ли число четным 
//( делится ли оно на два без остатка)


Console.WriteLine("Введите число");
int a =Convert.ToInt32 (Console.ReadLine());

if ( a %2 == 0) Console.WriteLine ("Число " + a + " четное");
else 
{
    Console.WriteLine ("Число " + a + " нечетное");
}
