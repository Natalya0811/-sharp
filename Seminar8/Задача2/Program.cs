// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов


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
    int index = 0;
    int sum = 0;
    int minsum = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        minsum += array[0, i];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {index + 1}");

}


int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
Result(array);
