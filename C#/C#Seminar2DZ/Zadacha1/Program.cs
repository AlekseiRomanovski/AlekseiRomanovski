﻿/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
1. Ввод числа от пользователя
2. Проверка числа, является ли оно трехзначным
3. Определение второй цифры числа
4. Вывод*/ 
Console.Write("Введите трехзначное число а = ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a%100;
int c = b/10;
int d = a/1000;
int e = a/100;
if (e==0 || d!=0)
{
    Console.Write($" Число {a} не является трехзначным");
}
else{
Console.Write($" Вторая цифра числа {c}");}