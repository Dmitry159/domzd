// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 29 прогр задает массив из 8 чисел и выводит их на экран

void FillArray(int[] numb)
{
    int arr = numb.Length;
    int i = 0;
    while (i < arr)
    {
        numb[i] = new Random().Next(0, 10);
        i++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int j = 0;
    for (j=0;j < count;j++)
    {
        System.Console.Write(array[j]);
        
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);









