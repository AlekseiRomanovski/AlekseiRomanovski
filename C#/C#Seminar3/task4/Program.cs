/* Напишите программу, которая принимает
на вход координаты двух точек и находит
рассстояние между ними в 2D пространстве
A(3,6); B(2,1)->5.09
A(7,-5); B(1,-1)->7.21
*/

double distance = 0;
double [] a = new double [2];
Console.WriteLine("Введите координаты х и у точки А");
for (int i = 0;  i < a.Length; i++)
{
    a [i] = Convert.ToDouble(Console.ReadLine());
}
double [] b = new double [2];
Console.WriteLine("Введите координаты х и у точки B");
for (int i = 0;  i < b.Length; i++)
{
    b [i] = Convert.ToDouble(Console.ReadLine());
}
distance = Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) );
distance = Math.Round(distance,2);
Console.WriteLine($"Растояние между точками А и В в 2D пространстве {distance}");