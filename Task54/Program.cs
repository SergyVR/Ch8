// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] matrix = InitMatrix(5,5); 
int[,] InitMatrix(int m, int n) 
{     int [,] resultMatrix = new int[m,n]; 
Random rnd = new Random();      
for (int i = 0; i < m; i++)   
  {   
    for (int j = 0; j < n; j++)        
   {   resultMatrix[i,j] = rnd.Next(10,50); }  
  }
    return resultMatrix;
 } 
 void PrintMatrix(int[,] matrix) 
 {     for (int i = 0; i < matrix.GetLength(0); i++) 
  {    for (int j = 0; j < matrix.GetLength(1); j++)
   
  {   Console.Write($"{matrix[i,j]}   ");         }        
    Console.WriteLine();     
  } 
 } 
PrintMatrix(matrix);
Console.WriteLine(); 

            int n = 5;
          
            int[] temp = new int[n];
 for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    temp[j] = matrix[i, j];
                Array.Sort(temp, (x, y) => y.CompareTo(x));
                for (int k = 0; k < n; k++)
                {
                    matrix[i, k] = temp[k];
                    Console.Write($"{matrix[i, k]}   ");
                }
                Console.WriteLine();
            }