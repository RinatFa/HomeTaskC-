// Задача 52. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(long [,] matr)
{
    for (long i = 0; i < matr.GetLength(0); i++)
    {
        for (long j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

string OutArray(long[,] lArray1){
    long k = lArray1.GetLength(0);  //максимальный индекс строк
    long n = lArray1.GetLength(1);  //максимальный индекс столбцов
    double dSum = 0;
    string sStr = string.Empty;
    for (long j = 0; j < n; j++){
        for (long i = 0; i < k; i++)
        {
        dSum = dSum + lArray1[i, j];
        }
        double dNumb = (double)(((int)(dSum / k * 10))) / 10;
        if (j == n - 1){sStr = sStr + "  "  + dNumb.ToString() + ".";} 
        else {sStr = sStr + "  "  + dNumb.ToString() + ";";}
        dSum = 0;
    }
    return sStr;
}

// 1. ввод значений
long[,] lArray1 = {{1, 4, 7, 2},
                   {5, 9, 2, 3},
                   {8, 4, 2, 4}
};
// 2. вычисление
string sString = OutArray(lArray1);
// 3. печать результата
PrintArray(lArray1);
Console.WriteLine("Среднее арифметическое каждого столбца: " + sString);
