// Задайте массив вещественных чисел
// Найдите разницу между максимальным и минимальным элементом массива

Console.WriteLine("Введите количество элементов в массиве");
int a = Convert.ToInt32(Console.ReadLine());

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
}
Console.WriteLine();



void Result(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {max - min}");
}


double[] array = new double[a];
FillArray(array);
PrintArray(array);
Result(array);