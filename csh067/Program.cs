// See https://aka.ms/new-console-template for more information
//Задача №67 сумма цифр в числе.
System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int SumNumber(int num)
{
    if (num ==0)
    {
        return 0;
    }
    return (num % 10 + SumNumber(num / 10) );
}

System.Console.WriteLine(SumNumber(N));
