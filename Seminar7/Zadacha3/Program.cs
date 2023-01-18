// Задайте двумерный массив из целых чисел
// Найдите среднее арифметическое элементов в каждом столбце


void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);

}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}


void Result(double[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double Sr = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           double res = (Sr + array[i, j]);
        
        res = res / 3;
        Console.Write(res + "; ");
        }
        Console.WriteLine();

    }
}



double[,] array = new double[3, 5];
FillArray(array);
PrintArray(array);
Result(array);

