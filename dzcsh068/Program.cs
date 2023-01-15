// Задача №68 Напишите прог. вычисления функции Аккермана с помощью рекурсии
// m=2;n=3->A(m,n)=9
// m=3;n=2->A(m,n)=29

Console.WriteLine("Введите число m = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n = ");
int n = int.Parse(Console.ReadLine());


int Akerman (int m, int n)
{
    if (m==0) 
    return n+1;
    else 
    if ((m !=0) && (n == 0))
    return Akerman (m-1,1);
    else
    return Akerman(m-1,Akerman (m,n-1));
      }
      
      
        Console.WriteLine(Akerman(m,n));
      
  