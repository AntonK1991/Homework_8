// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int Input(string data)
{
    Console.Write(data);
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0) Console.WriteLine("Значение должно быть больше 0");
    return n;
}

int[,,] RandomFillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArrayByLines(int[,,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            //Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array [i,j,k]} ({i};{j};{k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
int row = Input("Введите X: ");
int col = Input("Введите Y: ");
int deep = Input("Введите Z: ");
int[,,] list = new int [row,col,deep];
RandomFillArray(list); 
PrintArrayByLines(list);
