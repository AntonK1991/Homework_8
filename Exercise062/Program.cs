// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


void SpiralFillArray(int[,] array)
{
    int count = 1;
    int size = 4;
    for (int j = 0; j < size; j++)
    {
        array[0, j] = count;
        count++;
        if (j == size - 1)
        {
            for (int i = 1; i < size; i++)
            {
                array[i, size - 1] = count;
                count++;
                if (i == size - 1)
                {
                    for (int k = size - 2; k >= 0; k--)
                    {
                        array[size - 1, k] = count;
                        count++;
                        if (k == 0)
                        {
                            for (int l = size - 2; l > 0; l--)
                            {
                                array[l, size - 4] = count;
                                count++;
                                if (l == 1)
                                {
                                    for (int m = size - 3; m < size - 1; m++)
                                    {
                                        array[size - 3, m] = count;
                                        count++;
                                        if (m == 2)
                                        {    
                                            for (int n = size - 2; n >= size - 3; n--)
                                            {
                                                array[size - 2, n] = count;
                                                count++;
                                            }
                                        }    
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
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

int[,] list = new int[4, 4];
SpiralFillArray(list);
PrintArray(list);