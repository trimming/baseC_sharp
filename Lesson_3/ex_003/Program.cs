// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++) {
    if(i == N) {
        Console.Write($"{Math.Pow(i, 3)}");
    } else {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }    
}