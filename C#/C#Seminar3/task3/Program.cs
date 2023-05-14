/* Написать программу, которая принимает
на вход число (N) и выдает таблицу
квадратов чисел от 1 до N*/

Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write($"{i*i}, ");
}