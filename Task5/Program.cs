// 5. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Enter 3-digit number:");
int a = int.Parse(Console.ReadLine()!);
int b = a/10;
int last_fig = a - b * 10;
Console.Write("Last figure of the number:");
Console.WriteLine(last_fig);