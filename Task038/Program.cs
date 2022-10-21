// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// 1. ввод значений
double[] InputArray(){
    int iLength = 0;
    while (iLength < 1){
        Console.Write("Введите число > 0 - размер массива = ");
        iLength = Convert.ToInt32(Console.ReadLine());
    }   // проверка на "0" и отрицательный размер
    double[] dArray = new double[iLength];

    for (int i = 0; i < iLength; i++){
        dArray[i] = new Random().Next(-99, 100);
    }   // случайные числа от -99 до 99
    return dArray;
}
// 2. вычисление
string OutArray(double[] dArray){
    int iLength = dArray.Length;
    string sStr = "[ " + dArray[0];
    for (int i = 1; i < iLength; i++){
        sStr = sStr + ", " + dArray[i];
    }
    sStr = sStr + " ]";

    double dDiff = 0;
    double dMax = -99;
    double dMin = 99;
    for (int i = 0; i < iLength; i++){
        if (dArray[i] > dMax) dMax = dArray[i];
        if (dArray[i] < dMin) dMin = dArray[i];
    }   // максимальное и минимальное из чисел массива
    dDiff = dMax - dMin;
    sStr = sStr + $"  ->  {dDiff}    (разница между макс. и миним. числами)";
    if (dDiff == 0) sStr = sStr + "  - максимальное число равно минимальному, разница = 0!";
    return sStr;
}

double[] iArray = InputArray();
string sString = OutArray(iArray);
// 3. печать результата
Console.WriteLine(sString);