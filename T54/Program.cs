/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
*/


int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random randomizer = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int temp = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[i, j];
        }
    }
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1) - 1; j++)
        {
            for (int next = j + 1; next < newMatrix.GetLength(1); next++)
                if (newMatrix[i, j] > newMatrix[i, next])
                {
                    temp = newMatrix[i, j];
                    newMatrix[i, j] = newMatrix[i, next];
                    newMatrix[i, next] = temp;
                }
        }
    }
    return newMatrix;
}

Console.WriteLine("Введите число строк:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns);

Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);

int[,] newMatrix = SortMatrix(matrix);
Console.WriteLine("Полученный массив:");
PrintMatrix(newMatrix);