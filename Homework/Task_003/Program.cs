// Найти максимальное из трех чисел
Console.Write("Введите первой число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = int.Parse(Console.ReadLine());

if ((A>B) && (A>C))
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(A);
}
else if ((B>A) && (B>C))
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(B);
}
else if ((C>A) && (C>B))
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(C);
}
else
{
    Console.WriteLine("Какая-то ошибка");
}