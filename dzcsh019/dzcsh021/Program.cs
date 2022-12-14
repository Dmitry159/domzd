// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача №21 на входе координаты двух точек на вуходе растояние между ними в 3D

System.Console.WriteLine("Введите координаты первой точки: ");
System.Console.Write("Введите координаты точки x,y,z: ");
float x = float.Parse(Console.ReadLine()!);
float y = float.Parse(Console.ReadLine()!);
float z = float.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите координаты второй точки: ");
System.Console.Write("Введите координаты точки x,y,z: ");
float x1 = float.Parse(Console.ReadLine()!);
float y1 = float.Parse(Console.ReadLine()!);
float z1 = float.Parse(Console.ReadLine()!);
//(x1-x)2+(y1-y)2+(z1-z)2
float diffx=(x1-x);
float kvadratx = MathF.Pow(diffx, 2);
float diffy=(y1-y);
float kvadraty = MathF.Pow(diffy, 2);
float diffz=(z1-z);
float kvadratz = MathF.Pow(diffz, 2);

float sum = kvadratx + kvadraty + kvadratz;
Console.WriteLine("Расстояние между точек: "+MathF.Round(MathF.Sqrt(sum),2));
