// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача№ 23 на входе N на выходе тадлица кубов чисел
//3->1.8.27
//5->1.8.27.125

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

    int i = 1;
    int M =1;
    while (N >=i)
    { 
        M=i*i*i;
        i++;
        Console.WriteLine( M );
    }
    return i;
