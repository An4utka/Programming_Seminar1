// 6. Показать вторую цифру трёхзначного числа
Console.WriteLine("Enter 3-digit number:");
int a = int.Parse(Console.ReadLine()!);
int b = a/10;
int c = a/100;
int middle = b - c*10;
Console.Write("Middle figure of the number:");
Console.WriteLine(middle);