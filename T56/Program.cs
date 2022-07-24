/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

void GetMinRow(int[,] matrix)
{
    int minsumm = 0;
    int summ = 0;
    List<int> minI = new List<int>();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minsumm = minsumm + matrix[0, j];
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];
        }
        if (summ < minsumm)
        {
            minsumm = summ;
        }
        summ = 0;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];
        }
        if (summ == minsumm)
        {
            minI.Add(i);
        }
        summ = 0;
    }

    Console.WriteLine($"Минимальная сумма элементов в строке: {minsumm}");
    Console.WriteLine("Номер строки (строк) с минимальной суммой:");
    foreach (var item in minI)
    {
        Console.WriteLine(item);
    }
}

Console.WriteLine("Введите число строк:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns);

Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);


GetMinRow(matrix);