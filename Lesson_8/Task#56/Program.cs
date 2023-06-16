// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;
using static System.Console;
Clear();
int rowNumber = Prompt("Введите номер строки: ");
int columnNumber = Prompt("Введите номер столбца: ");
int[,] collection = GetArray(rowNumber, columnNumber);
PrintArray(collection);
WriteLine();
WriteLine(String.Join(' ', GetSumEachRow(collection)));
int rowWithMinSum = GetRowWithMinSum(GetSumEachRow(collection));
WriteLine($"Строка с наименьшой суммой элементов: {rowWithMinSum}");

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

int[] GetSumEachRow(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow[i] += array[i, j];
        }
    }
    return sumRow;
}

int GetRowWithMinSum(int[] array)
{
    int min = array[0];
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) result = i;
    }
    return result + 1;
}