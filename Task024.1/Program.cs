﻿// Сформируйте трёхмерный массив . Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
// создан через рандом, элементы могут повторятся
int SetNamber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[,,] Get3DMatrix(int rows, int columns, int depth, int minValue = 10, int maxValue = 100)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rand = new Random();


    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                matrix[i, j, k] = rand.Next(minValue, maxValue + 1);
            }

        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2) ; k++)
            {
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }

            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}

int rows = SetNamber("rows");
int columns = SetNamber("columns");
int depth = SetNamber("depth");


int[,,] array = Get3DMatrix(rows, columns, depth);
Print3DMatrix(array);
