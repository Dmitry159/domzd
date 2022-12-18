// See https://aka.ms/new-console-template for more information
//Задача 26: принимает число выдает количество цифр в числе
//456-3

Console.WriteLine("Введите число : ");
int number = int.Parse(Console.ReadLine()!);

int GetCountNuw(int num)
{
    int i = 0;
    while (number > 0) 
    {
        number = number / 10;
        i++;
    }
    return i;
}
Console.WriteLine($"Колличество чисел = {GetCountNuw(number)}");