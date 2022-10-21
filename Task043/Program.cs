// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// доп. проверка:  0,5  0,5  -1  2  ->  (1; 1)

// 1. ввод значений
double GetValue(string sText){
    Console.Write(sText + ": ");
    double dValue = Convert.ToDouble(Console.ReadLine());
    return dValue;
}
// 3. печать результата
void PrintResult(double dK1, double dK2, double dB1, double dB2, string sResult){
    string sOutput = $"| y = {dK1} * x + {dB1}; y = {dK2} * x + {dB2} |  ->  " + sResult;
    Console.WriteLine(sOutput);
}
// 2. вычисление
string GetPoint(double dK1, double dK2, double dB1, double dB2){
    string sStr = "";
    if (dK1 != dK2){
        double dX = (dB2 - dB1) / (dK1 - dK2);        // вычисление координаты x
        double dY = dK1 * dX + dB1;                   // вычисление координаты y
        sStr = $"({dX}; {dY})";
    }
    else{
        sStr = " нет точки пересечения, k1 и k2 должны различаться! ";
    }
    return sStr;
}

double dB1 = GetValue("b1");
double dK1 = GetValue("k1");
double dB2 = GetValue("b2");
double dK2 = GetValue("k2");

string sPoint = GetPoint(dK1, dK2, dB1, dB2);
PrintResult(dK1, dK2, dB1, dB2, sPoint);
