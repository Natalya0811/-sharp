// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Akkerman(m,n);


void Akkerman(int m, int n)
{
    Console.Write(Ak(m, n)); 
}


int Ak(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ak(m - 1, 1);
    }
    else
    {
        return (Ak(m - 1, Ak(m, n - 1)));
    }
}

