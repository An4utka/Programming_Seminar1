// 7. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int a = new Random().Next(10,100);
Console.WriteLine(a);
int first_num = a/10;
int second_num = a - first_num*10;
if (first_num>second_num)
{
    Console.Write("The biggest figure:");
    Console.Write(first_num);
}
if (second_num>first_num)
{
    Console.Write("The biggest figure:"); 
    Console.Write(second_num);
}