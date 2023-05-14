/*Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние
 между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double distance = 0;
double [] a = new double [3];
Console.WriteLine("Введите координаты х и у и z точки А");
for (int i = 0;  i < a.Length; i++)
{
    a [i] = Convert.ToDouble(Console.ReadLine());
}
double [] b = new double [3];
Console.WriteLine("Введите координаты х и у и z точки B");
for (int i = 0;  i < b.Length; i++)
{
    b [i] = Convert.ToDouble(Console.ReadLine());
}
distance = Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2) );
distance = Math.Round(distance,2);
Console.WriteLine($"Растояние между точками А и В в 3D пространстве {distance}");