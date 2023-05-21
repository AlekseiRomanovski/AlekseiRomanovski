/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Input (string text)
{
    Console.Write(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int Power(int a, int b)
{
    double c = Convert.ToDouble(a);
    double d = Convert.ToDouble(b);
    int result = Convert.ToInt32(Math.Pow(c, d));
    return result;
}
int a = Input ("Введите основание: ");
int b = Input ("Введите  показатель степени: ");
if (b < 0)
{
    Console.WriteLine("Показатель не должен быть меньше нуля");
    return;
}
Console.WriteLine($"Число {a} в степени {b} равно {Power (a,b)}");