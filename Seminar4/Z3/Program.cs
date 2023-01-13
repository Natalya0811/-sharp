// Напишите программу, которая задает массив из 8 целых чисел
// с клавиатуры, и далее выводит массив на экран в одну строку


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a];

for (int i = 0; i < a; i++)
{
    array[i] = new Random().Next(a + 1);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
