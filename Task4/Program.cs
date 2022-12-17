// 4. Выяснить является ли число чётным
int a = new Random().Next(1,100);
Console.Write("a=");
Console.WriteLine(a);
if (a%2==0)
{
    Console.Write("Even");
}
else Console.Write ("Uneven");