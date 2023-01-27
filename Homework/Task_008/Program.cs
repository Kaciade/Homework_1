// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите любое число от 10 до 99: ");
int Number = int.Parse(Console.ReadLine());
int Max = 0;

int MaxDigit()
{
    int DigitOne = Number / 10;
    int DigitTwo = Number % 10;
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

    return Max;
}

MaxDigit();
System.Console.WriteLine();
System.Console.WriteLine($"В числе {Number} наибольшая цифра {Max}");
System.Console.WriteLine();