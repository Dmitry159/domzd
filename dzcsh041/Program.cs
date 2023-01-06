// See https://aka.ms/new-console-template for more information
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
//ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");
string elements=Console.ReadLine();
int[] array=GetArrayFromString(elements);

Console.WriteLine(String.Join(" ",(array)));//выводит массив

int[] GetArrayFromString(string stringArray)
{
    string[]nums=stringArray.Split();//собирает строку в массив
  int[] res=new int[nums.Length];
  
    for(int i=0;i<nums.Length;i++)
    {
                  res[i]=int.Parse(nums[i]);
    }
    return res;
 }
 int TheSumNum(int[] nums)
 {
int sum =0;
for(int i=0;i<nums.Length;i++)
{
    if(nums[i]>0)
    {
        sum++;
    }
}
return sum;
 }
 
Console.WriteLine($"Колличество чисел больше 0 = {TheSumNum(array)}");
