// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

long getPowNumber(int number, int pow) {
    long powNumber = number;
    for(int i = 1; i < pow; i++) {
        powNumber *= number; 
    }
    return powNumber;
}
Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());
Console.Write(getPowNumber(A, B));