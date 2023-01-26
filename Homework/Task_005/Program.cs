// Показать четные числа от 1 до N
int A = 1;
Console.Write("Введите число: ");
int B = int.Parse(Console.ReadLine());
int C = 0;
int count = 0;

while (count < B)
{
    C=A%2;
    if (C == 0)
    {
        Console.WriteLine(A);
    }
    A++;
    count++;
}