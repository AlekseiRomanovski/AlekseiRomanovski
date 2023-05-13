// Написать программу, которая на вход принимает два числа и проверяет, являются ли одно число квадратом другого
Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
int a2 = a*a;
int b2 = b*b;
if (a == b2)
{
    Console.Write("число a является квадратом числа b");
    return;
} 
if (b == a2)
{
    Console.Write("число b является квадратом числа a");
    return;
}
    Console.Write("a не является квадратом числа b");