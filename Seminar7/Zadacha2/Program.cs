// Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента, или же указание, что такого элемента нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 10);

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
    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            if (n == array[i, j]) Console.WriteLine($"Позиция данного числа в массиве {i},{j}");
            else Console.WriteLine($"Числа нет");


}





int[,] array = new int[4, 5];
FillArray(array);
PrintArray(array);
Result(array);