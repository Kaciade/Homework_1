// Удалить вторую цифру трёхзначного числа
Console.Write("Введите трёхзначное число: ");
int A = int.Parse(Console.ReadLine());
int B = 0;

int NumberWithoutSecDig()
{
    B = A / 100 * 10 + A % 10;
    return B;
}

NumberWithoutSecDig();

Console.WriteLine($"Если из числа {A} удалить вторую цифру, получится число {B}");