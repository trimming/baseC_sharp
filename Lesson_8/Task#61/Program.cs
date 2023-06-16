// 61
// Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.
using System;
using static System.Console;
Clear();
Write("Введите размер треугольника: ");
int triangleSize = int.Parse(ReadLine());
int row = triangleSize;
int column = row * 2 - 1;
int[,] array = GetArray(row, column);
PrintArray(array);
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    // for (int i = 0; i < m; i++)
    // {
    //     for (int j = 0; j < n; j++)
    //     {
    //         result[i, j] = new Random().Next(0);
    //     }
    // }
    return result;
}

void PrintArray(int[,] inArray)
{
    int[,] pyramid = new int[inArray.GetLength(0), inArray.GetLength(1)];
    int k = 1;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {

            pyramid[i, inArray.GetLength(1) / 2 + 1] = k;
            pyramid[i, inArray.GetLength(1) / 2 - i] = k;
            // pyramid[inArray.GetLength(0)-i-1, inArray.GetLength(1)-j-1]
            if (pyramid[i - 1, j - 1] != null && pyramid[i - 1, j + 1] != null)
            {
                pyramid[i, j] = pyramid[i - 1, j - 1] + pyramid[i - 1, j + 1];
            }

                Write($"{pyramid[i, j],2} ");
        }
        WriteLine();
    }
}

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j],5} ");
//         }
//         WriteLine();
//     }
// }
