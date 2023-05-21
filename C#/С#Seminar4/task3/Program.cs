/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/


int Multi(int a)
{
    int mult = 1;
    for (int i = 1; i <= a; i++)
    {
        mult *=i;
    }
    return mult;
}

int result = Multi(4);
Console.WriteLine(result);
int result1 = Multi(5);
Console.WriteLine(result1);
