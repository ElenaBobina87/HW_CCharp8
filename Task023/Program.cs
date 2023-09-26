//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] SumElementRows(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];
        }
    }
    return array;

}

int FindIndexMinElement(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}

int rows = SetNamber("rows");
int columns = SetNamber("columns");
if (rows != columns)
{
    int[,] array = GetMatrix(rows, columns);
    PrintMatrix(array);
    int[] arraySumRows = SumElementRows(array);
    System.Console.WriteLine(string.Join(' ', arraySumRows));
    System.Console.WriteLine($"Индекс строки с наименьшей суммой элементов {FindIndexMinElement(arraySumRows)}");
}
else
{
    System.Console.WriteLine("Колличество строк не должно совпадать с колличеством столбцов");
}
