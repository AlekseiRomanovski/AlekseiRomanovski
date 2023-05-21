/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Input (string text)
{
    Console.Write(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int Sum(int a)
{
   int sum = 0;
   while (a> 0)
   {
       int b = a%10;
       sum = sum + b;
       a/=10; 
   }
   return sum;
}

int a = Input ("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {a} = {Sum(a)}");