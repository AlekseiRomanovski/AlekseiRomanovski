/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Prompt
double Multi(double a, double b)
{
    double result = Math.Pow(a, b);
    return result;
}
double result1 = Multi(3, 5);
Console.WriteLine(result1);
double result2 = Multi(2, 4);
Console.WriteLine(result2);