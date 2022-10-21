// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// 1. ввод значений
int[] InputArray(){
    int iLength = 0;
    while (iLength < 1){
        Console.Write("Введите число > 0 - размер массива = ");
        iLength = Convert.ToInt32(Console.ReadLine());
    }   // проверка на "0" и отрицательный размер
    int[] iArray = new int[iLength];

    for (int i = 0; i < iLength; i++){
        iArray[i] = new Random().Next(100, 1000);
    }   // случайные числа от 100 до 999
    return iArray;
}
// 2. вычисление
string OutArray(int[] iArray){
    int iLength = iArray.Length;
    string sStr = "[ " + iArray[0];
    for (int i = 1; i < iLength; i++){
        sStr = sStr + ", " + iArray[i];
    }
    sStr = sStr + " ]";

    int iCol = 0;
    for (int i = 0; i < iLength; i++){
        if (iArray[i] % 2 == 0) iCol += 1;              
    }
    sStr = sStr + $"  ->  {iCol}    (количество четных трехзначных чисел)";
    return sStr;
}

int[] iArray = InputArray();
string sString = OutArray(iArray);
// 3. печать результата
Console.WriteLine(sString);
