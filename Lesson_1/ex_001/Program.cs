Console.Clear();
Console.Write("Введите первое число для сравнения: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int num2 = int.Parse(Console.ReadLine());
while( num1 == num2 ){
    Console.WriteLine("Вы ввели два одинаковых числа!");
    Console.Write("Введите второе число для сравнения: ");
    num2 = int.Parse(Console.ReadLine());
}
if(num1 > num2) 
{
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine($"max = {num2}");
}
