// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] firstMartrix = InitMatrix(4,4); 

int[,] secomdMartrix = InitMatrix(4,4); 
int[,] InitMatrix(int m, int n) 
{     int [,] resultMatrix = new int[m,n]; 
Random rnd = new Random();      
for (int i = 0; i < m; i++)   
  {   
    for (int j = 0; j < n; j++)        
   {   resultMatrix[i,j] = rnd.Next(1,10); }  
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
PrintMatrix(firstMartrix);
Console.WriteLine(); 
PrintMatrix(secomdMartrix);

int[,] resultMatrix = new int[4,4];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
PrintMatrix(resultMatrix);