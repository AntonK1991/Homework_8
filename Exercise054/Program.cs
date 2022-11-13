// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

int Input(string data)
{
    Console.Write(data);
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0) Console.WriteLine("Значение должно быть больше 0");
    return n;
}

int[,] RandomFillArray (int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int j = 0; j < array.GetLength (1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

int[,] SortRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                if (array[i, j] > array[i, n])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, n];
                    array[i, n] = temp;
                }
            }
        }
    }
    return array;
}

Console.Clear();
int row = Input("Введите количество строк двумерного массива: ");
int col = Input("Введите количество столбцов двумерного массива: ");
int[,] list = new int[row, col];
RandomFillArray (list);
Console.WriteLine("\n"+"Задан массив: ");
PrintArray(list);
SortRowArray(list);
Console.WriteLine("\n"+"Строки массива отсортированы по убыванию: ");
PrintArray(list);


