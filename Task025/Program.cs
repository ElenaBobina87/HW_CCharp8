// Напишите программу, которая заполнит спирально массив 4 на 4.


void SpiralMatrix(int[,] matrix)
{
    int value = 1;
    int startRow = 0;
    int startCol = 0;
    int endRow = 3;
    int endCol = 3;
    while (startRow <= endRow && startCol <= endCol)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            matrix[startRow, i] = value++;
        }
        startRow++;

        for (int i = startRow; i <= endRow; i++)
        {
            matrix[i, endCol] = value++;
        }
        endCol--;

        for (int i = endCol; i >= startCol; i--)
        {
            matrix[endRow, i] = value++;
        }
        endRow--;

        for (int i = endRow; i >= startRow; i--)
        {
            matrix[i, startCol] = value++;
        }
        startCol++;
    }
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

int[,] arr = new int[4, 4];
SpiralMatrix(arr);
PrintMatrix(arr);






