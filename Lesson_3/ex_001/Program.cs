//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите число: ");
string numberToTest = Console.ReadLine();
Console.WriteLine(numberToTest.Length / 2);
int test = 0; 
for(int i = 0; i < (numberToTest.Length / 2); i++) {
    if(numberToTest[i] == numberToTest[(numberToTest.Length - 1)- i]) {
        test++;
    }    
}

if(test == numberToTest.Length / 2) {
    Console.Write($"{numberToTest} - число палиндром");
} else {
    Console.Write($"{numberToTest} - обычное число");
}