// Показать вторую цифру трёхзначного числа
Console.Write("Введите трёхзначное число: ");
int A = int.Parse(Console.ReadLine());
string B = A.ToString();
char c = B[B.Length - 2];
Console.WriteLine("Вторая цифра числа: " + c);