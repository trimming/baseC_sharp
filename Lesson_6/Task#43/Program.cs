﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void CoordinateDotCrossing(double b1, double b2, double k1, double k2)
{
    double x = b2 - b1 / k1 - k2;
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты точки пересечения: ({x:f2};{y:f2})");
}
Console.Clear();
double b1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
CoordinateDotCrossing(b1, b2, k1, k2);