// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Minimum(int[,] matrix, out int minI, out int minJ)
{
    minI = 0;
    minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[minI, minJ] < matrix[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }
}

int[,] NewMatrix(int[,] matrix, int minI, int minJ)
{
    int[,] newMatr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        for (int j = 0; j < newMatr.GetLength(1); j++)
        {
            if (i != minI || j != minJ)
            {
                newMatr[k, l] = matrix[i, j];
            }
            l++;
        }
        l=0;
        k++;
    }
    return newMatr;
}

int rows = ReadInt("Введите колличество строк матрицы ");
int cols = ReadInt("Введите колличество столбцов матрицы ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
Minimum(myMatrix, out int minI, out int minJ);
PrintMatrix(NewMatrix(myMatrix, minI, minJ));