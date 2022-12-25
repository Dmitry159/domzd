// See https://aka.ms/new-console-template for more information
//Задача№ 69На входе 2 числа на вых 1 в степени 2 РЕКУРСИЯ

int Stepen(int a, int b)
{
    if (b ==0)
    {
        return 1;
    }
    return (a * Stepen(a, b-1));
}

Console.WriteLine("Введите число A: ");
int A = int .Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int .Parse(Console.ReadLine()!);
Console.Write($"число {A} в степени {B} = {Stepen(A,B)}");
