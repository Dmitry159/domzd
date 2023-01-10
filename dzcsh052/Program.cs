// See https://aka.ms/new-console-template for more information
//Задача №52 Задайте двумерный массив из целых чисел, найдите среднее арифм.в каждом столбце

System.Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[]averagesColumns = GetResultArray(array);
Console.WriteLine($"Среднее арифметическое");
Console.WriteLine($"{String.Join(" ; " ,averagesColumns)}");
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}
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

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i=0; i< array.GetLength(0); i++)
        {
            sum +=array[i,j];
                    }
        result [j]=Math.Round(sum / array.GetLength(0),2);
}
return result ;
}