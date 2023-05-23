Console.Clear();
Console.Write("Введите число больше еденицы: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while(count <= N)
{
    if(count % 2 == 0)
    {
    Console.Write($"{count}, ");
    }
    count++;
}