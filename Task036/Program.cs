// Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// 1. ввод значений
int[] InputArray(){
    int iLength = 0;
    while (iLength < 1){
        Console.Write("Введите число > 0 - размер массива = ");
        iLength = Convert.ToInt32(Console.ReadLine());
    }   // проверка на "0" и отрицательный размер
    int[] iArray = new int[iLength];

    for (int i = 0; i < iLength; i++){
        iArray[i] = new Random().Next(-99, 100);
    }   // случайные числа от -99 до 99
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

    int iSum = 0;
    for (int i = 0; i < iLength; i++){
        if (i % 2 > 0) iSum += iArray[i];              
    }
    sStr = sStr + $"  ->  {iSum}    (сумма элементов на нечетных позициях)";
    return sStr;
}

int[] iArray = InputArray();
string sString = OutArray(iArray);
// 3. печать результата
Console.WriteLine(sString);