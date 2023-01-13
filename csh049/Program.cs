// See https://aka.ms/new-console-template for more information
//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так: 
//1 4 7 2 
//5 9 2 3
// 8 4 2 4
// A  = m+n 


System.Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);
ChangeArray(array);
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
            
        }
        Console.WriteLine();
    }
}
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}
  Console.WriteLine();
int[,] ChangeArray (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (j % 2 == 0) inArray[i, j] = inArray[i, j] * inArray[i, j];
            }
        }
    }
    return inArray;
   
    Console.Write($"{inArray } ");
}
PrintArray(array);

ChangeArray(array);