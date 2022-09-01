/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Write("введите количество строк в массиве n= ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количества столбцов в массиве m= ");
int m = int.Parse(Console.ReadLine());

int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

double SredArif(int[,] array, int N)
{
    double srArif = 0;
    int count=0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
           
                summ += array[j, i];             
               
        }
         count++; 
      
         srArif = 1.0*summ / N;
        Console.WriteLine($"Среднее арифметическое {count} столбца равно {srArif:f1}");
    }

    return srArif;
}

int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);
Console.WriteLine();
SredArif(myArray, n);


