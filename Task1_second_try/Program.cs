// 1. По двум заданным числам проверять является ли первое квадратом второго


Console.WriteLine("Enter first number");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number");
int b = int.Parse(Console.ReadLine()!);

if (b == a * a)
{
    Console.Write("Yes");
}
else 
{
    Console.Write("No");
}