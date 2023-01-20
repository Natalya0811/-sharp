// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц

int[,] array = new int[2, 2];
int[,] secondArray = new int[2, 2];
int[,] resultArray = new int[2, 2];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(secondArray);
PrintArray(secondArray);
Console.WriteLine($"Итоговый массив после произведения");


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

void Result(int[,] array, int[,] secondArray, int[,] resultArray)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < array.GetLength(1); n++)
            {
                sum += array[i, n] * secondArray[n, j];
            }
            resultArray[i, j] = sum;
        }
    }
}


Result(array, secondArray, resultArray);
PrintArray(resultArray);


