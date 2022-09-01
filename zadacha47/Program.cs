/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

Console.Write("Введите число строк= ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов= ");
int n = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n, int a, int b)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().NextDouble() * (b-a)-a;

    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{array[i, j]:f2} ");
        Console.WriteLine();
    }
}

double[,] myArray = GetArray(m, n, 30, 100);
PrintArray(myArray);

