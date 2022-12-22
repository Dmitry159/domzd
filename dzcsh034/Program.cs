// See https://aka.ms/new-console-template for more information
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void FillArray(int[] numb)
{
    int arr = numb.Length;
    int i = 0;
    while (i < arr)
    {
        numb[i] = new Random().Next(100, 1000);
        i++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int j = 0;
    int N = 0;
    for (j = 0; j < count; j++)
    {

        Console.WriteLine(array[j]);
        if (array[j] % 2 == 0)
        {
            N++;
        }
    }
    Console.Write(N);
}
int[] array = new int[3];

FillArray(array);
PrintArray(array);



