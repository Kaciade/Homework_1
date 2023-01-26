// Выяснить является ли число чётным
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
int B = A % 2;

if (B == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}