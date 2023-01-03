// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i=a; i <=b; i++)//i>=b;i-- в обратную сторону
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a , int b)
{
    if(a <= b)return NumbersRec(a+1,b) + $"{a} ";
   else return String.Empty;
    }

Console.WriteLine(NumbersFor(1,10));
Console.WriteLine(NumbersRec(1,10));