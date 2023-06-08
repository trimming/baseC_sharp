/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }    
}
int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    int i = 0;
    foreach(int item in array)
    {
        arrayCopy[i] = item;
        i++;
    }
    return arrayCopy;
}
Console.Clear();
int[] collection = new int[new Random().Next(5, 10)];
FillArray(collection);
Console.WriteLine($"[{String.Join(", ", collection)}]");
Console.WriteLine($"[{String.Join(", ", CopyArray(collection))}]");