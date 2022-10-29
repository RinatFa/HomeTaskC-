// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultArray(int[,] matr1, int[,] matr2, int[,] matr3)
{
    for (int i = 0; i < matr3.GetLength(0); i++)
    {
        for (int j = 0; j < matr3.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                matr3[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
}

int[,] arr1 = { { 2, 4 }, { 3, 2 } };
int[,] arr2 = { { 3, 4 }, { 3, 3 } };
int[,] arr3 = new int[2, 2];

PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();
MultArray(arr1, arr2, arr3);
PrintArray(arr3);
