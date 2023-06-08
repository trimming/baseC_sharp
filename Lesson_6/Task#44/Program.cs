﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int[] FillArrayFibonacciNum(int length)
{
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;    
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
    return array;
}

Console.Clear();
Console.Write("Введите количество чисел Фибоначчи, которое хотите увидеть: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] collection = FillArrayFibonacciNum(size);
Console.WriteLine($"{String.Join(" ", collection)}");
