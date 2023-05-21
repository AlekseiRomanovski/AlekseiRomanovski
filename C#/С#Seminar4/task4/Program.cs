/* Напишите программу , которая выводит 
массив из 8 элементов, заполненый
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
void FillArray(int[] collection) 
{
    int length = collection.Length;
        for (int i = 0; i < length; i++)
    {
        collection[i] = new Random ().Next (0, 2);
    }
}
int [] array = new int [8];
FillArray(array);
Console.WriteLine(String.Join(",",array));