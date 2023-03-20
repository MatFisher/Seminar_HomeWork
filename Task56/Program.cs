// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[] MinSumOfRow(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
    }
    return sumRow;
}

int LineMinSum(int[] arr)
{
    int lineMin = arr[0];
    int lineMinIndex = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < lineMin)
        {
            lineMin = arr[i];
            lineMinIndex = i;
        }
    }
    return lineMinIndex + 1;
}


int[,] matr = CreateMatrixRndInt(3, 5, 0, 10);
Console.WriteLine();
PrintMatrix(matr);
Console.WriteLine();
int[] arraySum = MinSumOfRow(matr);
int rowIndex = LineMinSum(arraySum);
Console.WriteLine($" {rowIndex} строка");
Console.WriteLine();