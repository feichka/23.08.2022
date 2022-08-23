/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
void NewMatrix(int[,]matrix)
{
  for (int i = 0; i< matrix.GetLength(0); i++)
  {
    for (int j = 0; j< matrix.GetLength(1); j++)
    {
      matrix[i,j] = new Random().Next(0,5);
      Console.Write(matrix[i,j] + " ");
    } 
     Console.WriteLine();
  }
 
}

void ProzMatrix (int[,]matrixOne, int[,]matrixTwo)
{
    int [,] ResultMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            ResultMatrix[i, j] = matrixOne[i,j] * matrixTwo[i,j];
            Console.Write(ResultMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
int[,]matrixOne = new int[n,m];
int[,]matrixTwo = new int[n,m];
Console.WriteLine("Первая матрица: ");
NewMatrix(matrixOne);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
NewMatrix(matrixTwo);
Console.WriteLine();
Console.WriteLine("Их произведение");
ProzMatrix(matrixOne, matrixTwo);