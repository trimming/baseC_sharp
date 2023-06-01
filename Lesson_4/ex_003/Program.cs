// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] getArray(int size) {
    int[] array = new int[size];
    for(int i = 0; i < size; i++) {
        array[i] = new Random().Next(99);
    }
    return array;
}
void showArray(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}, ");
    }
}
Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
int[] result = getArray(sizeArray);
showArray(result);
Console.WriteLine();
Console.WriteLine($"[{String.Join(" ,", result)}]");