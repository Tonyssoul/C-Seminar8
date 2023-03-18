// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
            matrix[i,j]= rand.Next(0,11);
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
            System.Console.Write(matrix[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
    
}

int[,] Zamena(int[,] matrix)
{
    int[,] matrix2 = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j=0; j<matrix.GetLength(0);j++)
        {
            matrix2[i,j] = matrix[j,i];
        }
       
    }
    return matrix2;
}




int rows = ReadInt("Введите колличество строк матрицы ");
int cols = ReadInt("Введите колличество столбцов матрицы ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
int[,] myMatrix2 = Zamena(myMatrix);
PrintMatrix(myMatrix2);