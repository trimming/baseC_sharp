// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].  
// Пример для массива из 5, а не 15 элементов. В своём решении сделайте для 15 
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5
int[] CreateArray( int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}
int GetCountTwoDigitItems(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        count += el >= 10 && el <= 99 ? 1 : 0;
    }
    return count;
}
int[] collection = CreateArray(15);
Console.WriteLine($"Количество элементов отрезка [10,99] массива [{String.Join(", ", collection)}] равно: {GetCountTwoDigitItems(collection)}");
