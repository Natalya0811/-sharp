// Задайте двумерный массив из целых чисел
// Найдите среднее арифметическое элементов в каждом столбце


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

void Result(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
    Console.WriteLine($"Среднее арифметическое {sum/array.GetLength(0)}");
    }
}

int[,] array = new int[3, 5];
FillArray(array);
PrintArray(array);
Result(array);

