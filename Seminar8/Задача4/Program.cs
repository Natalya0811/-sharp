// Сформируйте трехмерный массив из уникальных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента


int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintResult(array3D);


void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
          for (int n = 0; n < array3D.GetLength(2); n++)
            array[i, j, n] = new Random().Next(10, 100);

}






void PrintResult(int[,,] array)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int n = 0; n < array3D.GetLength(2); n++)
            {
                Console.Write($"{array3D[i, j, n]}({i},{j},{n}) ");
            }
        }
    }
}





