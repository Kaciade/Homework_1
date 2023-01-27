// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число от 1 до 9999: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"Дано число: {A}");

if (A / 100 > 0)
{
    Console.WriteLine($"Третьей цифрой числа {A} является цифра {A / 100 % 10}");
}
else
{
    Console.WriteLine($"У числа {A} нет третьей цифры");
}