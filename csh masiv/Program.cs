// See https://aka.ms/new-console-template for more information
//Создаем двумерный массив



void PrintArray(int[,]array)
{
    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j=0; j< array.GetLength(1);j++)
        {
            Console.Write($" { array[i , j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,10);
                }
        
    }
}
int[,] matrix = new int[3,4];
PrintArray(matrix);// печатает пустой массив
FillArray(matrix);// заполняет массив случайными числами
Console.WriteLine();// разделяет с новой строки массивы
PrintArray(matrix);// печатает заполненый массив