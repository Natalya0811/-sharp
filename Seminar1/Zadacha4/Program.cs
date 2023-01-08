// Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все четные числа от 1 до N

Console.WriteLine("Введите число");
int n =Convert.ToInt32 (Console.ReadLine());

if (n < 2)
{
Console.WriteLine("Четных чисел нет");
}
else {
    for(int i=2; i<=n; i++)
{
if(i%2 == 0)
Console.Write( i+ "," );
}
}

