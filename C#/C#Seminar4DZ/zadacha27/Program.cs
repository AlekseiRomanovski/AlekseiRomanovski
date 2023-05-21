/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Sum(int a)
{
    int sum = 0;
    double b = a;
    for (int i = 1; i < count; i++)
    {
        sum +=i;
    }
    return sum;
}

int result = Sum(452);
Console.WriteLine(result);

 
/*int main()
 {
	int x, n=1;
	cin >> x;
	while ((x/=10) > 0) n++;
	cout << n;
	return 0;
}*/