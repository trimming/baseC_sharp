// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int getSumDigitOfNum(int num) {
    int sum = 0;
    while(num > 0) {
        int modulo = num % 10;
        sum = sum + modulo;
        num /= 10; 
    }
    return sum;
}
Console.Clear();
int number = new Random().Next();
Console.WriteLine($"Сумма цифр в числе {number} равна {getSumDigitOfNum(number)}");

