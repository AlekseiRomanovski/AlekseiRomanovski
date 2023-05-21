/*Напишите программу, которая задаёт
массив из 8 элементов и выводит их на экран.*/

int Input (string text)
{
    Console.Write(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int [] RandomArray (int Length, int minNumber, int maxNumber) 
{
    int [] array = new int [Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random ().Next (minNumber,maxNumber + 1);
    }
    return array;
}
int length = Input("Введите длину массива  ");
int min = Input("Введите начальное значение случайного числа  ");
int max = Input("Введите конечное значение случайного числа  ");
int [] array = RandomArray (length, min, max);
Console.WriteLine(String.Join(",",array));