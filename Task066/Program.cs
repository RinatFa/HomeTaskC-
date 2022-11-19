// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

long GetValue(string sStr){
    Console.Write("Введите число " + sStr + " = ");
    long numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;
}

long PrintRecurs(long s, long e){
    long lNumb = 0;
    if (s <= e){
        lNumb = s + PrintRecurs(s + 1, e);
    }
    return lNumb;
}

// 1. ввод значений
long lM = GetValue("M");    //1    4   1 и 15 = 120
long lN = GetValue("N");    //15   8   4 и 8 = 30
// 2. вычисление
long lSum = PrintRecurs(lM, lN);
// 3. печать результата
Console.WriteLine(lSum);
