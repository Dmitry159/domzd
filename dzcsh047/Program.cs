﻿// See https://aka.ms/new-console-template for more information
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
//числами.
//m = 3, n = 4.
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue); 
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
Console.Write("Введите количество строк массива: m=");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
