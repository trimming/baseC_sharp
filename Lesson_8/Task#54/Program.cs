// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using System;
using static System.Console;
Clear();
int rowNumber = Prompt("Введите номер строки: ");
int columnNumber = Prompt("Введите номер столбца: ");
int[,] collection = GetArray(rowNumber, columnNumber);
PrintArray(collection);
WriteLine();
PrintArray(ReverseArray(collection));

int Prompt(string message)
{
    Write(message);
    string value = ReadLine();
    return int.Parse(value);
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[,] ReverseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) * array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[j, k] < array[j, k + 1])
                {
                    int temp = array[j, k];
                    array[j, k] = array[j, k + 1];
                    array[j, k + 1] = temp;
                }
            }
        }
    }
    return array;
}