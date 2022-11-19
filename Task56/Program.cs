// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = InitMatrix(5,5); 
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
PrintMatrix(matrix);
Console.WriteLine(); 
int summ = 0;
 void PrintSumm(int[,] matrix) 
 {   for (int i = 0; i < matrix.GetLength(0); i++)
   {  for (int j = 0; j < matrix.GetLength(1); j++)   
          
  {  summ = summ + matrix[i,j];           }    
      
      Console.Write($"{summ}  "); 
      summ = 0;  
  } 
 } 
PrintSumm(matrix);

int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}