﻿/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.Write("Введите цифру обозначающую день недели  ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0 && a < 8)
{
    if (a==6 || a==7)
    {
    Console.Write($" день {a} выходной");
    }
    else{
    Console.Write($" день {a}, не выходной");}
}
else{
    Console.Write($" Цифра {a}, не является обозначением дня недели");}