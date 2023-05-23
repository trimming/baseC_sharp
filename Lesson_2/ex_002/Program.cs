// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
int num = new Random().Next();
Console.WriteLine(num);
if (num < 100 && num > -100) {
    Console.WriteLine("третьей цифры нет");    
} else {
    int num1 = num;
    int count = 0;
    while(num1 > 999 || num1 < -999) {
        num1 = num1 / 10;
        count++;
    }
    Console.WriteLine(Math.Abs(num1) % 10);    
}
