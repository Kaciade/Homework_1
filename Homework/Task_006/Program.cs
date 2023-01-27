// Показать последнюю цифру трёхзначного числа
Console.Write("Введите трёхзначное число: ");
int A = int.Parse(Console.ReadLine());
string B = A.ToString();
char c = B[B.Length - 1];
Console.WriteLine("Последняя цифра числа: " + c);