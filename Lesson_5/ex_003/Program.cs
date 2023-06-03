// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] GetStringArray(string collection)
{
    string[] str = collection.Split(" ");
    double[] num = new double[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        num[i] = Convert.ToDouble(str[i]);        
    }
    return num;
}
double ShowMaxMinDiff(double[] array)
{
    double min = array[0];
    double max = array[1];
    foreach (double item in array)
    {
        max = item > max ? item : max;
        min = item < min ? item : min;
    }
    return max - min;
}

Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string doubleNumbers = Console.ReadLine();
double[] doubleNumArray = GetStringArray(doubleNumbers);
Console.WriteLine($"Разность максимального и минимального чисел массива [{String.Join(", ", doubleNumArray)}] равна {ShowMaxMinDiff(doubleNumArray)}");