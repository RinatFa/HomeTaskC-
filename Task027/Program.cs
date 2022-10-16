// Задача 27: Напишите метод, который принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// 1. ввод значений
int GetValue(){
    Console.Write("Введите число = ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;
}
// 2. вычисление
string SumFigures(int numberA){
    int numberB = 0;
    int numberC = numberA;                //для вывода
    if (numberA < 0) numberA = -numberA;  //отриц. числа
    int sum = 0;                          //сумма цифр  
    while (numberA > 0){ 
        numberB = numberA % 10;
        numberA = numberA / 10;
        sum += numberB;
    }
    string sStr = "Сумма цифр числа " + numberC + 
           " равна " + sum;
    return sStr;
}

int numberA = GetValue();
string sString = SumFigures(numberA);
Console.WriteLine(sString);
