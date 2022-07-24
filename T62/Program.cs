/* Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
*/

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[4, 4];
    int number = 1;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[0, j] = number;
        number++;
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        matrix[i, matrix.GetLength(1) - 1] = number;
        number++;
    }
    for (int j = matrix.GetLength(1) - 2; j >= 0; j--)
    {
        matrix[matrix.GetLength(0) - 1, j] = number;
        number++;
    }
    for (int i = matrix.GetLength(0) - 2; i > 0; i--)
    {
        matrix[i, 0] = number;
        number++;
    }
    for (int j = 1; j < matrix.GetLength(1) - 1; j++)
    {
        matrix[1, j] = number;
        number++;
    }
    for (int j = 2; j > 0; j--)
    {
        matrix[2, j] = number;
        number++;
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);