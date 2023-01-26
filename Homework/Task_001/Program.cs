// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int result = a%b;

if (result==0)
{
    Console.WriteLine("Первое число является квадратом второго");
}

else
{
    Console.WriteLine("Первое число не является квадратом второго");
}