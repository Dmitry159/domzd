// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве
//находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран. m = 3, n = 4. 
//0 1 2 
//3 1 2 
//3 4 2 
//3 4 5

int[,] GetArray(int n, int m)
 {    
     int[,] result = new int[n, m];  
        for (int i = 0; i < n; i++)   
          {        
             for (int j = 0; j < m; j++)    
               {     
                        result[i, j] = i + j;        
                }   
                  }    
                   return result; 
                   } 
                   System.Console.WriteLine("Введите количество строк массива: ");
                   int rows = int.Parse(Console.ReadLine()); 
                   System.Console.WriteLine("Введите количество столбцов массива: ");
                    int columns = int.Parse(Console.ReadLine());
                     int[,] array = GetArray(rows, columns); 
                     PrintArray(array); 
                     void PrintArray(int[,] inArray)
                      {    
                         for (int i = 0; i < inArray.GetLength(0); i++)  
                            {    
                                     for (int j = 0; j < inArray.GetLength(1); j++) 
                                             {           
                                                  Console.Write($"{inArray[i, j]} ");  
                                                         }      
                                                            Console.WriteLine(); 
                                                                } 
                                                                }
                                                                