// See https://aka.ms/new-console-template for more information
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3 7 22 2 78] -> 76

void FillArray(double[] numb)
{
    double arr = numb.Length;
    int i = 0;
    while (i < arr)
    {
        numb[i] = new Random().Next(1, 100);
        i++;
    }
}
void PrintArray(double[] array)
{
    double count = array.Length;
    int j = 0;
    double N = 0;
     double max=array[0];
    double min=array[0];
    for (j = 0; j < count; j++)
    {

        Console.WriteLine(array[j]);
        if (array[j]>max)
        {
            max=array[j];
        }
        if (array[j]<min)
        {
            min=array[j];
        }
    }
    N=max- min;
    Console.Write(N);
}
double[] array = new double[3];

FillArray(array);
PrintArray(array);