// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(GetSum(m, n));

int GetSum(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    int sum = GetSum(m, n - 1) + n;

    return sum;
}
