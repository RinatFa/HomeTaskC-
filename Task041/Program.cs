// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1. ввод значений
int[] InputArray(){
    int iLength = 0;
    while (iLength < 1){
        Console.Write("Введите планируемое для ввода количество чисел > 0 = ");
        iLength = Convert.ToInt32(Console.ReadLine());
    }   // проверка на "0" и отрицательный размер
    int[] iArray = new int[iLength];

    int iNumber = 0;
    for (int i = 0; i < iLength; i++){
        Console.Write("Введите число (остановка ввода: -1234 ) = ");
        iNumber = Convert.ToInt32(Console.ReadLine());
        if (iNumber == -1234){break;}
        else{iArray[i] = iNumber;}
    }   // ввод чисел с клавиатуры
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
        if (iArray[i] > 0) iCol += 1;              
    }
    sStr = sStr + $"  ->  {iCol}    (количество чисел > 0)";
    return sStr;
}

int[] iArray = InputArray();
string sString = OutArray(iArray);
// 3. печать результата
Console.WriteLine(sString);
