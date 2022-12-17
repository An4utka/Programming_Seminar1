// 8. Удалить вторую цифру трёхзначного числа
Console.WriteLine("Enter 3-digit number:");
int a = int.Parse(Console.ReadLine()!);
int b = a/100;
int c = a/10;
int del = b*10 + a - c*10;
    Console.Write("Result:"); 
    Console.Write(del);