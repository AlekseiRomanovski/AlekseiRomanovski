/* Написать программу, которая выводит случайное число
из отрезка [10, 99] и показывает наибольшую цифру числа.
1. Генерация случайного числа
2. Найти наибольшую цифру числа
3. Вывод*/
 
Random rand = new Random();
int number = rand.Next(10, 100);
int a = number/10;
int b = number%10;
if(a>b)
{
Console.WriteLine($"Наше число {number}. {a} > {b}. Результат {a}");
}
else if (a<b)
{
Console.WriteLine($"Наше число {number}. {b} > {a}. Результат {b}");
}
else {
Console.WriteLine($"Наше число {number}. {a} = {b}.");
}