// Напишите программу, которая заполнит спирально массив 4 на 4

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, a];

int n= 1;
int i = 0;
int j = 0;

while (n <= a * a)
{
    array[i, j] = n;
    if (i <= j + 1 && i + j < a - 1)
        ++j;
    else if (i < j && i + j >= a - 1)
        ++i;
    else if (i >= j && i + j > a - 1)
        --j;
    else
        --i;
    ++n;
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("");
        Console.WriteLine("");
    }
}
