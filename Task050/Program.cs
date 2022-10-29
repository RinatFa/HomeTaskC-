// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(long[,] matr){
    for (long i = 0; i < matr.GetLength(0); i++){
        for (long j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

long VerifyIJ(string sStr){
    long temp;          //Проверка на ввод числа!
    var vNumb = " ";        //в текстовый формат
    while (long.TryParse(vNumb, out temp) == false){
        Console.Write("Введите " + sStr + " элемента: ");
        vNumb = Console.ReadLine();
        if (long.TryParse(vNumb, out temp) == false){
            Console.WriteLine("Введите число!");
        }
    }
    return Convert.ToInt32(vNumb) - 1;  //перевод в индексы элемента
}

string OutArray(long[,] lArray1, long i, long j){
    long k = lArray1.GetLength(0);  //максимальный индекс строк
    long n = lArray1.GetLength(1);  //максимальный индекс столбцов
    string sStr = string.Empty;
    if (i >= 0 && i < k){
        if (j >= 0 && j < n) { sStr = lArray1[i, j].ToString(); }
        else { sStr = "такого числа в массиве нет"; }
    }
    else { sStr = "такого числа в массиве нет"; }
    return sStr;
}

// 1. ввод значений
long[,] lArray1 = {{1, 4, 7, 2},
                   {5, 9, 2, 3},
                   {8, 4, 2, 4}
};
long i = VerifyIJ("строку");
long j = VerifyIJ("столбец");
// 2. вычисление
string sString = OutArray(lArray1, i, j);
// 3. печать результата
PrintArray(lArray1);
Console.WriteLine(sString);
