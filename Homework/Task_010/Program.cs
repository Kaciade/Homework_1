// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Чтобы выяснить кратно ли первое число второму");
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
int C = 0;
int MultipleNumber()
{
    C = A % B;
    return C;
}
MultipleNumber();
if (C == 0)
{
    System.Console.WriteLine($"Число {A} кратно числу {B}");
}
else
{
    Console.WriteLine($"Число {A} не кратно числу {B}, остаток от деления равен {A % B}");
}