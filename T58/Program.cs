/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int [,] GetMatrix(int rows, int columns)
{
    int [,] matrix = new int[rows,columns];
    Random randomizer = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = randomizer.Next(1,10);
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

int [,] ProductOfMatrix(int [,] first, int [,] second)
{
    int [,] resultMatrix = new int [first.GetLength(0), first.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = first[i,j] * second [i,j];
        }
    }
return resultMatrix;
}

Console.WriteLine("Введите число строк:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int columns = int.Parse(Console.ReadLine());

int[,] firstMatrix = GetMatrix(rows, columns);

Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);

int[,] secondMatrix = GetMatrix(rows, columns);

Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);

int[,] resultMatrix = ProductOfMatrix(firstMatrix, secondMatrix);

Console.WriteLine("Результат произведения матриц:");
PrintMatrix(resultMatrix);
