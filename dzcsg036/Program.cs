// See https://aka.ms/new-console-template for more information
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void FillArray(int[] numb)
{
    int arr = numb.Length;
    int i = 0;
    while (i < arr)
    {
        numb[i] = new Random().Next(0, 100);
        i++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int sum=0;
    int j = 0;
    for (j=0;j < count;j++)
    {
        
        
        Console.Write($"\t{array[j]}");
       
           if(j%2==0)
        {
            sum=array[j]+sum;
        }
        
        
    }
    Console.WriteLine( -(sum));
}
int[] array = new int[4];

FillArray(array);
PrintArray(array);
