// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет

Console.WriteLine("Введите число");
int a =Convert.ToInt32 (Console.ReadLine());

if (a < 100)
{
Console.WriteLine("У заданного числа третьей цифры нет");
}

else {

     do {
        a = a / 10;
    }
 while (a > 999); 

int b = a %10;
Console.WriteLine($"Третья цифра введённого числа: {b}");
}