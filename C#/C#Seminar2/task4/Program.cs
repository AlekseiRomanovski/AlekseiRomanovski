/*написать программу, которая будет принимать
на ввод два числа и выводить, является ли
первое число кратным второму. Если число 1 
не кратно числу 2, то программа выводит остаток от деления
*/
Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a%b;
if (c==0)
{
    Console.Write($"{a} кратно {b}");
}
else{
Console.Write($"{a} не кратно {b} Остаток {c}");
}