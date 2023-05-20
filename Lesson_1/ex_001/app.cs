console.clear();
console.write('Введите первое число для сравнения: ');
int num1 = int.Parse(console.ReadLine());
console.write('Введите второе число для сравнения: ');
int num2 = int.Parse(console.ReadLine());
while( num1 == num2 ){
    Console.WriteLine('Вы ввели два одинаковых числа!');
    console.write('Введите второе число для сравнения: ');
    num2 = int.Parse(console.ReadLine());
}
if(num1 > num2) 
{
    Console.WriteLine($'max = {num1}');
}
else
{
    Console.WriteLine($'max = {num2}');
}