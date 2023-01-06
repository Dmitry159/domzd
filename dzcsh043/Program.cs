// See https://aka.ms/new-console-template for more information
//Программа находит точку пересечения двух прямых y=k1*x+b1 , y=k2*x+b2;
Console.Clear();
Console.Write("Введите через пробел b1,k1,b2,k2 ");
string[] f=Console.ReadLine().Split();
double b1=double.Parse(f[0]);
double k1=double.Parse(f[1]);
double b2=double.Parse(f[2]);
double k2=double.Parse(f[3]);

Console.WriteLine(String.Join(" ",GetPoint(b1,k1,b2,k2)));
double[] GetPoint(double nb1, double nk1, double nb2, double nk2)
{
    double[] res=new double[2];
    res[0]=(nb2-nb1) / (nk1-nk2);
    res[1]=nk1*res[0]+nb1;
    return res;
}