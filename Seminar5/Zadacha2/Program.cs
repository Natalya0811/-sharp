// Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечетных позициях


Console.WriteLine("Введите количество элементов в массиве");
int a = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
}
Console.WriteLine();


void Summa(int[] array)
{
    int sum = 0;
    for (int i = 1; i <= array.Length; i += 2)
    sum += array[i];
    Console.WriteLine($"Сумма элементов,стоящих на нечетных позициях, равна {sum}");
}

int[] array = new int[a];
FillArray(array);
PrintArray(array);
Summa(array);