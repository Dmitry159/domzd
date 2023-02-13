Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements=Console.ReadLine();
string[] baseArray=GetArrayFromString(elements);

//Console.WriteLine(String.Join(" ",res(baseArray)));//выводит массив

string[]GetArrayFromString(string stringArray)
{
    string[]nums=stringArray.Split();//собирает строку в массив
    string[]res=new string[nums.Length];
    for(int i=0;i<nums.Length;i++)
    {
        res[i]=nums[i];
    }
    return res;
}

string[]strings = baseArray;
var result = strings.Where(strings => strings.Length <=3).ToArray();
Console.WriteLine(string.Join(" , ", result));
