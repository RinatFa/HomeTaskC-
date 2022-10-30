// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(long[,] matr){
    for (long i = 0; i < matr.GetLength(0); i++){
        for (long j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void OutArray(long[,] lArray1){
    long k = lArray1.GetLength(0);  //максимальный индекс строк
    long n = lArray1.GetLength(1);  //максимальный индекс столбцов
    long lMaxPos = 0;
    long lTemp = 0;
    for (long i = 0; i < k; i++){
        for (long j = 0; j < n; j++){
            lMaxPos = j;      //позиция максимального числа, начиная с 0
            for (long l = j + 1; l < n; l++){ //цикл для остальной группы в строке
                if (lArray1[i, l] > lArray1[i, lMaxPos]){ //если найдено большее число
                    lMaxPos = l;       //запоминается позиция большего числа
                }
            }
            if (lMaxPos > j){
                lTemp = lArray1[i, j]; //смена мест чисел по двум позициям
                lArray1[i, j] = lArray1[i, lMaxPos];
                lArray1[i, lMaxPos] = lTemp;
            }
        }
    }
}

// 1. ввод значений
long[,] lArray1 = {{1, 4, 7, 2},
                   {5, 9, 2, 3},
                   {8, 4, 2, 4}
};
PrintArray(lArray1);
// 2. вычисление
OutArray(lArray1);
// 3. печать результата
Console.WriteLine();
PrintArray(lArray1);
