// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

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

// void Chastota(int[,] matrix)
// {
//     for (int l = 0; l < 10; l++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 // count = (l == matrix[i, j]) ? count++ : count + 0;
//                 if (l == matrix[i, j]) count++;
//             }
//         }
//         if (count > 0)
//         {
//         System.Console.WriteLine($"{l} встречается {count} раз");
//         }
//     }

// }

void Chastota(int[,] matrix)
{
    var count = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count[matrix[i, j]]++;
        }
    }

    for (int i = 0; i < count.Length; i++)
    {
        if(count[i]!=0)
        {
            System.Console.WriteLine($"{i} значение встречается {count[i]} раз");
        }
    }
}

int rows = ReadInt("Введите колличество строк матрицы ");
int cols = ReadInt("Введите колличество столбцов матрицы ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
Chastota(myMatrix);