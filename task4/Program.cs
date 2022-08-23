/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

void NewMatrix(int[,,]matrix)
{
  for (int i = 0; i< matrix.GetLength(0); i++)
  {
    for (int j = 0; j< matrix.GetLength(1); j++)
    {
        for (int k = 0; k< matrix.GetLength(2); k++)

      matrix[i,j,k] = new Random().Next(-10,11);
    } 
  }
 
}
void PrintMatrix (int[,,]matrixOne)
{
    for (int i = 0; i< matrixOne.GetLength(0); i++)
  {
    for (int j = 0; j< matrixOne.GetLength(1); j++)
    {
        for (int k = 0; k< matrixOne.GetLength(2); k++)
        Console.WriteLine(matrixOne[i,j,k] + " (" + i + ", " + j + ", " + ", " + k + ")");
}
  }
}

Console.WriteLine("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,]matrixOne = new int[x,y,z];
NewMatrix(matrixOne);
PrintMatrix(matrixOne);