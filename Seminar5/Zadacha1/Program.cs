// Задайте массив заполненный случайными положительными трехзначными числами
// Напишите программу, которая покажет количество четных чисел в массиве


Console.WriteLine("Введите количество элементов в массиве");
int a = Convert.ToInt32(Console.ReadLine());


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
}
Console.WriteLine();


void Result(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    Console.WriteLine($"Количество чётных чисел в массиве равно {count}");
}


int[] array = new int[a];
FillArray(array);
PrintArray(array);
Result(array);