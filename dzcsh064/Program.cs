// See https://aka.ms/new-console-template for more information
//Задача №64 Задайте N. Напишите программу которая выведет все натуральные числа от N до 1
//Выполнить с помошью рекурсии

Console.WriteLine("Введите число N : ");
double num = int.Parse(Console.ReadLine()!);

double FulRec (double n)
{
    if (n==1) return 1;
    else  Console.Write(n );
    n=n-1;
    return  FulRec(n);
     
      }
           
      Console.WriteLine(FulRec(num));

