// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным


Console.WriteLine("Введите число от 1 до 7");
int a =Convert.ToInt32 (Console.ReadLine());
 
 if ( a >=1 && a <=7 )
 {
   if ( a==6 | a==7) Console.WriteLine("Сегодня выходной");
   else Console.WriteLine("Сегодня рабочий день");
 }
else Console.WriteLine ("Некорректное число");