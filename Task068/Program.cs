// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

long GetValue(string sStr){
    Console.Write("Введите число " + sStr + " = ");
    long numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;
}

long AkkermanRecurs(long s, long e){
    long lNumb = 0;
    if (s >= 0 & e >= 0){
        if (s == 0){
            lNumb = e + 1;
        }
        if (s > 0 & e == 0){
            lNumb = AkkermanRecurs(s - 1, 1);
        }
        if (s > 0 & e > 0){
            lNumb = AkkermanRecurs(s - 1, AkkermanRecurs(s, e - 1));
        } 
    }
    return lNumb;
}

// 1. ввод значений
long lM = GetValue("m");    //3   2   3 и 2 = 29
long lN = GetValue("n");    //2   3   2 и 3 = 9
// 2. вычисление
long lAkk = AkkermanRecurs(lM, lN);
// 3. печать результата
Console.WriteLine("A(m,n) = " + lAkk);
