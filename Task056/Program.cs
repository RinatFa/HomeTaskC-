// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(long[,] matr){
    for (long i = 0; i < matr.GetLength(0); i++){
        for (long j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

long OutArray(long[,] lArray1){
    long k = lArray1.GetLength(0);  //максимальный индекс строк
    long n = lArray1.GetLength(1);  //максимальный индекс столбцов
    long lNumbRow = 0;
    long lMinSum = 0;
    long lSum = 0;
    for (int i = 0; i < k; i++){
        lSum = 0;        //обнуление суммы для нового счета по j
        for (int j = 0; j < n; j++){
            lSum += lArray1[i, j];
        }
        if (lMinSum > lSum | lMinSum == 0){
            lMinSum = lSum;
            lNumbRow = i + 1;      //позиция на 1 больше индекса
        }
    }
    return lNumbRow;
}

// 1. ввод значений
long[,] lArray1 = {{1, 4, 7, 2},
                   {5, 9, 2, 3},
                   {8, 4, 2, 4}
};
// 2. вычисление
OutArray(lArray1);
// 3. печать результата
PrintArray(lArray1);
long lN = OutArray(lArray1);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {lN} строка");
