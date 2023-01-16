// Пользователь вводит с клавиатуры M чисел
// Посчитайте, сколько чисел больше 0 ввел пользователь


Console.WriteLine("Введите количество чисел M");
int m = Convert.ToInt32(Console.ReadLine());


void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
}

int Result(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+=1;
    }
    return count;
    
}


int[] array = new int[m];
FillArray(array);
Result(array);
Console.WriteLine($"Количество чисел больше 0 : {Result(array)}");