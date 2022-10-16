// Задача 25: опишите метод, который принимает на вход два 
// числа (A и B) и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// 1. ввод значений
int GetValueA(){
    Console.Write("Введите число A = ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;
}
int GetValueB(){
    Console.Write("Введите число B (степень) = ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    return numberB;
}
// 2. вычисление
string Exponent(int numberA, int numberB){
    int result = 1;
    for (int iCount = 0; iCount < numberB; iCount++){
        result *= numberA;
    }
    string sStr = "Результат = " + result;
    return sStr;
}

int numberA = GetValueA();
int numberB = GetValueB();
string sString = Exponent(numberA, numberB);
Console.WriteLine(sString);
