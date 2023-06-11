// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
using System;
using static System.Console;
int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

int Prompt(string message) 
{
    Write(message);
    string value = ReadLine();
    return int.Parse(value);
}

bool CheckUserNumbers(int row, int column, int[,] array)  
{
    return row < (array.GetLength(0) + 1) && column < (array.GetLength(1) + 1) && row > 0 && column > 0;
}

int FindItemArray(int row, int column, int[,] array) // Метод ищет значение по позиции строки и столбца со стороны пользователя
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[row - 1, column - 1] == array[i, j])
            {
                result = array[i, j];
            }
        }
    }
    return result;
}
Clear();
int[,] collection = GetArray(4, 5, 1, 20);
PrintArray(collection);
int rowNumber = Prompt("Введите номер строки: ");
int columnNumber = Prompt("Введите номер столбца: ");
if (CheckUserNumbers(rowNumber, columnNumber, collection))
{
    WriteLine($"Значение числа по позиции [{rowNumber}, {columnNumber}]: {FindItemArray(rowNumber, columnNumber, collection)}.");
}
else
{
    WriteLine("Такого числа в массиве нет.");
}
