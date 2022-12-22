// See https://aka.ms/new-console-template for more information
//Задача 27 на входе число на вых,сумма цифр
//452=11
//82=10
//9012=12

Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int GetCountNuw(int num)
{
    int k = 0;
    int m = 0;
    while (num > 0)
    {

        k = num % 10 ;
        m = m + k;
        num = num / 10;
    }
    return m;
}
Console.WriteLine($"Сумма цифр = {GetCountNuw(num)}");

