// See https://aka.ms/new-console-template for more information
//Задача№ 25 на входе два числа A B=> A в степени В
//3,5=>243
//2,4=>16

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

int i =1;
int M =1;
while (B>=i)
{
    M=M*A;
    i++;
}
Console.WriteLine( M);
