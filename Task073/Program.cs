// 73. Есть число N. Скольно групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты.
// Например для N = 50, M получается 6 
// Одно из решений :

// Группа 1: 1 
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// Группа 5: 7 16 24 36 40 
// Группа 6: 5 32 48

// Ещё одно решение:

// Группа 1: 1 
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// Группа 5: 16 24 36 40 
// Группа 6: 32 48

void PrintArray(long[] matr, long lN3){
    Console.Write($"Группа {lN3}: ");
    for (long i = 1; i < matr.Length; i++){
        if (matr[i] > 0){
            Console.Write($"{matr[i]} ");
        }   //отсекает с "0"
    }
    Console.WriteLine();
}

long VerifyN(){
    long temp;          //Проверка на ввод числа!
    var vNumb = " ";        //в текстовый формат
    while (long.TryParse(vNumb, out temp) == false){
        Console.Write("Введите число, определяющее ряд чисел: ");
        vNumb = Console.ReadLine();
        if (long.TryParse(vNumb, out temp) == false){
            Console.WriteLine("Введите число!");
        }
    }
    return Convert.ToInt32(vNumb);
}

long[] InputArray(long lN1, long lN2){
    long[] lArray = new long[lN1];
    if (lN2 == 2){
        for (long i = 3; i <= lN1; i++){
            lArray[i - 1] = i;
        }   // ввод чисел в массив 2
    }
    return lArray;
}

void SelectNumberPrime2Array(long[] lNumb1, long[] lNumb2, long lN1){
    long k = 0;
    long l = 0;
    bool bPrime = true;
    SelectionSort(lNumb1);
    SelectionSort(lNumb1);
    for (long i = 2; i < lN1; i++){
        if (lNumb1[i] > 0){   //отсекает с "0"
            bPrime = true;
            k = lNumb1[i];
            for (long j = 1; j < i; j++){
                if (lNumb1[j] > 0){   //отсекает с "0"
                    l = lNumb1[j];
                    if (NODX2(l, k) > 1){
                        bPrime = false;
                        break;
                    }
                }
            }
            if (bPrime == false){
                lNumb2[1] = lNumb1[i];
                SelectionSort(lNumb2);
                lNumb1[i] = 0;
            }
        }
    }
    SelectionSort(lNumb1);
}

void SelectionSort(long[] lNumbers){
    long lCount = 0;
    long lMinPos = 0;
    long lTemp = 0;
    lCount = lNumbers.Length;    //максимальный индекс
    for (long i = 0; i < lCount; i++){
        lMinPos = i;
        for (long j = i + 1; j < lCount; j++){
            if (lNumbers[j] < lNumbers[lMinPos])
            {
                lMinPos = j;   //поиск следующей минимальной позиции
            }
        }
        if (lMinPos > i){
            lTemp = lNumbers[i];
            lNumbers[i] = lNumbers[lMinPos];
            lNumbers[lMinPos] = lTemp;
        }
    }
}

long NODX2(long M, long N){
    //Взаимно простые по условию задачи, не по математике:
    //Взаимно простые числа, если NOD этих чисел равен 1
    if (M > 0 & N > 0){
        if (N % M > 0) { return 1; }
        else { return 2; }
    }
    else { return 0; }
}

// 1. ввод значений
long lN = VerifyN();
long[] lArray1 = InputArray(2, 1);
lArray1[1] = 1;
long[] lArray2 = InputArray(lN, 2);
lArray2[1] = 2;
long[] lArray3 = InputArray(lN, 1);
long[] lArray4 = InputArray(lN, 1);
long[] lArray5 = InputArray(lN, 1);
long[] lArray6 = InputArray(lN, 1);

// 2. вычисление
SelectNumberPrime2Array(lArray2, lArray3, lN);
SelectNumberPrime2Array(lArray3, lArray4, lN);
SelectNumberPrime2Array(lArray4, lArray5, lN);
SelectNumberPrime2Array(lArray5, lArray6, lN);

// 3. печать результата
PrintArray(lArray1, 1);
PrintArray(lArray2, 2);
PrintArray(lArray3, 3);
PrintArray(lArray4, 4);
PrintArray(lArray5, 5);
PrintArray(lArray6, 6);
