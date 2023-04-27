Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = - a - 1;
int i = b;
while (i < a)
{
    i++;
    Console.Write(i);
}