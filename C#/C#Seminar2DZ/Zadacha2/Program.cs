﻿/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
while (a > 999)
{
   a = a/=10;
}
if (a < 100)
{
    Console.Write("В введеном числе нет третьей цифры");
}
else{
Console.Write($"Третьей цифрой числа, является {a%10}");}