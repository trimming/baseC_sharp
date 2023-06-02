// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int ShowEvenNumInArr(int[] array) {
    int count = 0;
    foreach( int item in array)
    {
        count += item % 2 == 0 ? 1 : 0;
    }
    return count;
}
Console.Clear();
int[] collection = GetRandomArray(10, 100, 999);
Console.WriteLine($"В массиве [{String.Join(" ,", collection)}] четных чисел: {ShowEvenNumInArr(collection)}");