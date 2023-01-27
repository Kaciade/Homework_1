// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите любое число от 10 до 99: ");
int A = int.Parse(Console.ReadLine());
int Max = 0;

int MaxDigit()
{
    int B = A / 10;
    int C = A % 10;
    if (B > C)
    {
        Max = B;
    }
    else
    {
        Max = C;
    }
    return Max;
}

MaxDigit();
Console.WriteLine($"В числе {A} наибольшая цифра {Max}");