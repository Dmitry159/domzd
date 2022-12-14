// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача № 19 Является ли пятизначное число полиндромом.

Console.WriteLine("Введите пятизначное число: ");
int N= int .Parse(Console.ReadLine());

if ( N<100000 && N>9999)
{
    

int A = N / 10000;
int B = N / 1000%10;
int C = N / 100%10;
int D = N /10% 10;
int E = N % 10;
Console.WriteLine($"{A}{B}{C}{D}{E}");
if (A == E & B == D)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}
}
else
{
Console.WriteLine("Это не пятизначное число");
}
