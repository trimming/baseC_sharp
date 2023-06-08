// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}
int[] GetMultEl(int[] array)
{   int size = (array.Length % 2 == 0) ? (array.Length / 2) : (array.Length / 2 + 1);
    int[] multEl = new int[size];
    for(int i = 0; i < array.Length / 2; i++)
    {
        multEl[i] = array[i] * array[array.Length - 1 - i];
        
    }
    if(array.Length % 2 != 0)
    {
        multEl[size - 1] = array[array.Length / 2];
    }
    return multEl;
}
Console.Clear(); 
int[] arr = CreateArray(7);
int[] multElArray = GetMultEl(arr);
Console.WriteLine($"Произведение пар чисел массива [{String.Join(", ", arr)}] -> [{String.Join(", ", multElArray)}]");