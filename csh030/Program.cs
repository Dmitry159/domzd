// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 30 Прогр создает массив

int N=8;
int [] arr=new int[N];
void Getarray(int[]array)
{
    
    for(int i=0;i<N ;i++)
    {
        array[i]=new Random().Next(0,100);
    
        Console.Write($"{array[i]}");
        i++;
    }
}
Getarray(arr);
