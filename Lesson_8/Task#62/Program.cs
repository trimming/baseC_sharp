// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using System;
using static System.Console;
Clear();
int[,] collection = GetArray(8, 8, 0);
PrintArray(collection);
WriteLine();


int[,] GetArray(int m, int n, int num)
{
    int[,] result = new int[m, n];
    for (int i = 0, j = 0; j < result.GetLength(1); j++, num++)
    {
        result[i, j] = num;
    }
    for (int i = 1, j = result.GetLength(1) - 1; i < result.GetLength(0); i++, num++)
    {
        result[i, j] = num;
    }
    for (int i = result.GetLength(0) - 1, j = result.GetLength(1) - 2; j >= 0; j--, num++)
    {
        result[i, j] = num;
    }
    for (int i = result.GetLength(0) - 1, j = 0; i > 0; i--, num++)
    {
        result[i, j] = num;
    }
    for (int i = 1, j = 1; j < result.GetLength(1) - 1; j++, num++)
    {
        result[i, j] = num;
    }
    for (int i = result.GetLength(0) - 2, j = result.GetLength(1) - 2; j > 0; j--, num++)
    {
        result[i, j] = num;
    }
    return result;

}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],4}");
        }
        WriteLine();
    }
}