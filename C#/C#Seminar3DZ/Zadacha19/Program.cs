﻿/*Напишите программу, которая принимает
на вход пятизначное число и проверяет,
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите число N = ");
int a = Convert.ToInt32(Console.ReadLine());
if (a/10000==0 || a/100000!=0)
{
    Console.Write($" Число {a} не является пятизначным");
}
else if (a/10000 == a%10 && (a/1000)%10 == (a%100)/10)
{
    Console.Write($" Число {a} является палиндромом");
}
else
{
    Console.Write($" Число {a} не является палиндромом");
}