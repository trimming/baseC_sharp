// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] CreateArrayFromUserNumbers(string numbers)
{
    string[] userStringArray = numbers.Split(" ");
    int[] arrayNumbers = new int[userStringArray.Length];
    for (int i = 0; i < userStringArray.Length; i++)
    {
        arrayNumbers[i] = Convert.ToInt32(userStringArray[i]);
    }
    return arrayNumbers;
}
void CheckUserNumbers(int[] array)
{
    int i = 0;
    foreach (int item in array)
    {
        if (item > 0)
        {
            i++;
        }
    }
    Console.WriteLine($"Вы ввели чисел больше 0: {i}.");
}
Console.Clear();
Console.Write("Введите числа через пробел: ");
string userNumbersInLine = Console.ReadLine();
int[] arrayFromUserNumbers = CreateArrayFromUserNumbers(userNumbersInLine);
CheckUserNumbers(arrayFromUserNumbers);