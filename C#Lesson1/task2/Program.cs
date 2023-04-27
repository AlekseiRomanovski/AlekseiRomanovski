Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
int b2 = b*b;
if (a == b2)
{
    Console.Write("a является квадратом числа b");
} 
else
{
    Console.Write("a не является квадратом числа b");
}