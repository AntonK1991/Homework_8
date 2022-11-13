// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Input(string data)
{
    Console.Write(data);
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0) Console.WriteLine("Значение должно быть больше 0");
    return n;
}

int[,] CheckInputAndCreateArray(int row, int col)
{
    while (row != col)
    {
        Console.WriteLine("Количество строк и столбцов должно быть равным! Повторите ввод!");
        row = Input("Введите количество строк массива: ");
        col = Input("Введите количество столбцов массива: ");
    }
    int[,] array = new int[row, col];
    Console.WriteLine("\n" + "Задан массив: ");
    return array;
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int FindSumAtRow(int[,] array, int n)
{
    int summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ += array[n, j];
    }
    return summ;
}

void FindMinSummRow(int[,] array)
{
    int minSumm = FindSumAtRow(array, 0);
   
    int minSummRow = 1;
    for (int k = 1; k < array.GetLength(0); k++)
    {
        int temp = FindSumAtRow(array, k);
        if (minSumm > temp)
        {
            minSumm = temp;
            minSummRow = k+1;   
        } 
    }
    Console.WriteLine("\n" + "Строка № " + minSummRow + " содержит наименьшую сумму элементов, равную " + minSumm + "." + "\n");
}

Console.Clear();
int row = Input("Введите количество строк массива: ");
int col = Input("Введите количеств столбцов массива: ");
int[,] list = CheckInputAndCreateArray(row, col);
RandomFillArray(list);
PrintArray(list);
FindMinSummRow(list);
