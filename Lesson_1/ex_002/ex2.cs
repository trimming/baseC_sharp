Console.Clear();
Console.WriteLine('Введите первое число для сравнения: ');
int num1 = int.Parse(console.ReadLine());
Console.WriteLine('Введите второе число для сравнения: ');
int num2 = int.Parse(console.ReadLine());
Console.WriteLine('Введите третье число для сравнения: ');
int num3 = int.Parse(console.ReadLine());
int max = num1;
if(num2 > max) 
{
    max = num2;
}
if(num3 > max) 
{
    max = num3;
}
Console.WriteLine($'max = {max}');
