/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int Countch(int ch)
{
    int count = 0;
    while (ch > 0)
    {
       int b = ch%10;
       count+=1;
       ch/=10; 
    }
    return count;
}
Console.Write("Введите число для определения его длины  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"->{Countch(a)}");