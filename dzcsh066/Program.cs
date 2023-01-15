
// Задача №66 Задайте значение M и N Напишите прог.которая найдет 
// сумму натуральных элементов в промежутке от M до N
// M=1;N=15 ->120  M=4;N=8 ->30

System.Console.WriteLine("Введите число M= ");
double M = double. Parse(Console.ReadLine());
System.Console.WriteLine("Введите число N= ");
double N = double. Parse(Console.ReadLine());
double max=0;

if (M>N)
{
max=M;M=N;N=max;
Console.WriteLine();
}
else
{
    Console.WriteLine();
}

double sum=0;
while (N>=M)
{
    sum=N+sum;
    N=N-1;
}
Console.WriteLine(sum);

//Console.WriteLine(F);