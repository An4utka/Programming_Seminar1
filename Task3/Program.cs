// 3. Найти максимальное из трех чисел
int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
int c = new Random().Next(1,100);
int max = a;
Console.Write("a=");
Console.WriteLine(a);
Console.Write("b=");
Console.WriteLine(b);
Console.Write("c=");
Console.WriteLine(c);

if (b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.Write("Max=");
Console.WriteLine(max);