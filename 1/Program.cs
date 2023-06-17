
семинар 3.7

//рандомные числа в двумерном массиве

Console.Write($"Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);


int[,] RandomArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = RandomArray(m,n);
PrintArray(array);

/* задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
A[i, j] = i + j. выведите полученный массив на экран.

0 1 2 3
1 2 3 4
2 3 4 5 */

Console.Write($"Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(m,n);
PrintArray(array);

//мое решение
/* задайте двумерный массив. найдите элементы, у которых оба индекса четные, 
и замените эти элементы на их квадраты.
сначала:
1 4 7 2 
5 9 2 3
8 4 2 4
1 2 3 4

после:
1 4 7 2 
5 (81) 2 (9)
8 4 2 4
1 (4) 3 (16) */

Console.Write($"Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

int[,] RandomArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
    return array;
}
int[,] SqrArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if((array[i, j] % 2) == 0)
            array[i, j] *= array[i, j];
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = RandomArray(m,n);
PrintArray(array);
Console.WriteLine();
PrintArray(SqrArray(array));


/* задайте двумерный массив. найдите сумму элементов, находящихся
на главной диагонали (с индексами (0,0);(1,1) и т.д
1 4 7 2
5 9 2 3
8 4 2 4
сумма = 1 + 9 + 2 = 12 */

Console.Write($"Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

int[,] RandomArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
    return array;
}
// void SumArray(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == j)
//             sum += array[i,j];
//         }
//     }
//             Console.Write($"сумма = {sum}");
// }

//решение учителя


void SumArray(int[,] array)
{
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    // //if(array.GetLength(0) < array.GetLength(1))
    // length = array.GetLength(0);
    // else
    // length = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    Console.Write($"сумма = {sum}");
}
    


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = RandomArray(m,n);
PrintArray(array);
Console.WriteLine();
SumArray(array);