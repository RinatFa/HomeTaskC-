// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Dimension3Array(long fN3, long[,,] fB){
    long i;
    long j;
    long l;
    long k = 0;         
    long MyRnd;
    long lTemp;
    long lN = 90;
    long[] fA = new long[lN];

    for (i = 0; i < lN; i++){
        fA[i] = i + 10;
    }   // значения элементов от 0 до 89 = от 10 до 99

    for (i = 0; i < lN - 1; i++){
        MyRnd = new Random().Next(1, (int)lN);
        lTemp = fA[MyRnd];
        fA[MyRnd] = fA[i];
        fA[i] = lTemp;    
    }   // случайные значения

    for (i = 0; i < fN3; i++){
        for (j = 0; j < fN3; j++){
            for (l = 0; l < fN3; l++){
                fB[i, j, l] = fA[k];
                k = k + 1;
            }
        }
    }   //заполнение трехмерного массива
}

string PrintRecurs(long s, long e, long[,,] fB){
    string sStr = string.Empty;
    long i = (s % 4) / 2;
    long j = s % 2;
    long k = s / 4;
    sStr = fB[i, j, k] + 
            "(" + i + "," + j + "," + k + ") ";    
    if (j == 1){sStr = sStr + Environment.NewLine;}
    if (s < e){
         sStr = sStr + PrintRecurs(s + 1, e, fB);
    }
    return sStr;
}

// 1. ввод значений
long fN3 = 2;
long[,,] fB = new long[fN3, fN3, fN3];
long lS = 0;
long lN = 7;    // 0 1 2 3 4 5 6 7 из 90 двузначных
// 2. вычисление
Dimension3Array(fN3, fB);
// 3. печать результата. Вывод трехмерного массива через рекурсию
string sStr = PrintRecurs(lS, lN, fB);
Console.WriteLine("Массив размером 2 x 2 x 2");
Console.Write(sStr);
