Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("не четное");
}