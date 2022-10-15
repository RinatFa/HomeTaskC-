// Задача 23: Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// 1. ввод значений
int GetValue(){
    Console.Write("Введите максмальное число = ");
    int max = Convert.ToInt32(Console.ReadLine());
    return max;
}
// 2. вычисление
void CubesFr1ToN(){
    int numberA = 1;
    int numberB = 1;
    int max = GetValue();
    while(numberA <= max){
        numberB = numberA * numberA * numberA;
        Console.Write(numberB + " ");
        numberA += 1;
    }
    Console.WriteLine("");
}

CubesFr1ToN();