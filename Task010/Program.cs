// Задача 10: Напишите метод, который принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// 1. ввод значений
int GetValue(){
    Console.Write("Введите трёхзначное число = ");
    int iNumb = Convert.ToInt32(Console.ReadLine());
    return iNumb;           
}
// 3. печать результата
void Print(int numberA, int numberB){
    string sStr = "Вторая цифра трёхзначного числа " 
                        + Convert.ToString(numberA) + 
              " равна " + Convert.ToString(numberB);
    Console.WriteLine(sStr);
}
// 2. вычисление
void DivMod2Fr3(){
    int numberA  = GetValue();  
    int numberB = numberA;
    if (numberA < 0) numberB = -numberA;
    numberB = numberB / 10 % 10;
    Print(numberA, numberB);
}

DivMod2Fr3();