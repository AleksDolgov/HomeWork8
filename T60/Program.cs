/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/

int [,,] GetThree3DArray (int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    Random randomizer = new Random();
           
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = randomizer.Next(10, 100);

                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j; b++)
                    {
                        for (int c = 0; c < k; c++)
                        {
                            if(array3D[i, j, k] == array3D[a, b, c])
                            {
                                array3D[i, j, k] = randomizer.Next(10, 100);
                                a = 0;
                                b = 0;
                                c = 0;
                            }
                        }

                    }
                }
            }

        }
    }    
            
    return array3D;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
        Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность массива по х:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размерность массива по у:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размерность массива по z:");
int z = int.Parse(Console.ReadLine());


int [,,] array3D = GetThree3DArray(x, y, z);

PrintArray(array3D);