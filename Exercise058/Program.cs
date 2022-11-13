// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Input(string data)
{
    Console.Write(data);
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 1) Console.WriteLine("Значение должно быть больше 1");
    return n;
}

int[,] RandomFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void MultMatrix(int[,] firstMartrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int summ = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        summ += firstMartrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = summ;
    }
  }
}

void PrintArray(int[,] array, int num)
{
    Console.WriteLine ("\n" + "Матрица № "+num+": ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintResult(int[,] array)
{
    Console.WriteLine ("\n" + "Произведение матриц: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int row = Input("Введите количество строк матриц: ");
int col = Input("Введите количеств столбцов матриц: ");
int[,] firstMatrix = new int [row, col];
int[,] secondMatrix = new int [row, col];
int[,] resultMatrix = new int[row,col];
RandomFillArray(firstMatrix);
PrintArray(firstMatrix, 1);
RandomFillArray(secondMatrix);
PrintArray(secondMatrix, 2);
MultMatrix(firstMatrix, secondMatrix, resultMatrix); 
PrintResult (resultMatrix);