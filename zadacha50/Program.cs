/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4       m = 1, n =7 -> такого числа в массиве нет */

Console.Write("введите количество строк в массиве n= ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количества столбцов в массиве m= ");
int m = int.Parse(Console.ReadLine());

Console.Write("Ведите позицию элемента в строке =  ");
int str = int.Parse(Console.ReadLine());
Console.Write("Введите позицию элемента в столбце = ");
int stol = int.Parse(Console.ReadLine());

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

int ZnachenieElem(int[,] array, int a, int b)
{
    int znach = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                znach = array[i, j];
            }
          
        }

    }
    return znach;
}

int[,] myArray = GetArray(n, m, 0, 100);
PrintArray(myArray);
Console.WriteLine();

int Ze = ZnachenieElem(myArray, str, stol);
if (Ze > 0)
    Console.WriteLine($"Значение элемента{Ze}");
else
    Console.WriteLine("Такого элемента в массиве нет");
