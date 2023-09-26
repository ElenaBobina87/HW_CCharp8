// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int SetNamber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[,] GetMatrix(int rows, int columns, int minValue = 1, int maxValue = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void BubbleSort(int[,] array)
{


    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {



            for (int i = 0; i < array.GetLength(1) - 1 - m; i++)
            {
                if (array[k, i] < array[k, i + 1])
                {
                    int temp = array[k, i];
                    array[k, i] = array[k, i + 1];
                    array[k, i + 1] = temp;
                }
            }

        }
    }
}

int rows = SetNamber("rows");
int columns = SetNamber("columns");
int[,] array = GetMatrix(rows, columns);
PrintMatrix(array);
BubbleSort(array);
System.Console.WriteLine();
PrintMatrix(array);
