/* Написать программу, которая принимает
на вход число (N) и выдает таблицу
квадратов чисел от 1 до N*/

Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());
while (n != 0)
{   Console.Write($"{n*n}, ");
    n = n - 1;
}