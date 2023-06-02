// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int SumItemOfOddIndexes(int[] array)
{
    int i = 0;
    int sum = 0;
    foreach (int item in array)
    {
        if (i % 2 == 0)
        {
            sum += 0; 
        } else {
            sum += item; 
        }
        i++;
    }
    return sum;
}
Console.Clear();
int[] arr = GetRandomArray(7, 1, 9);
Console.WriteLine($"В массиве [{String.Join(" ,", arr)}] сумма элементов нечетных индексов равна {SumItemOfOddIndexes(arr)}");