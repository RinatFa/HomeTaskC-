// Задача 13 (A): ВАРИАНТ ОТСЧЕТА ОТ ПРАВОГО КРАЯ ЧИСЛА
// Напишите метод, который выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6 (!)
// 78 -> третьей цифры нет
// 32679 -> 6

// 1. ввод значений
int GetValue(){
    Console.Write("Введите число = ");
    int iNumb = Convert.ToInt32(Console.ReadLine());
    return iNumb;           
}
// 2. вычисление
void DivMod3FrNA(){
    int numberA  = GetValue();
    int numberB = 0;
    int numberC = 0;
    int Divider = 10;
    int count = 0;
    string sStr = "";
    numberC = numberA;
    if (numberA < 0) numberA = -numberA;
    while (numberB < numberA){
        numberB = numberA % Divider;
        Divider = Divider * 10;       
        count += 1;
    }   // подсчет количества цифр count в числе
    if (count < 3){
        sStr = "Третьей цифры нет!";
    }
    else{
        numberB = numberA / 100;    // для (count >= 3)
        if (count > 3){
            numberB = numberB % 10;
        }
        sStr = "Третья цифра числа " + Convert.ToString(numberC) + 
            " равна " + Convert.ToString(numberB) + 
            "  (отчет от правого края числа)";
    }
    Console.WriteLine(sStr);
}

DivMod3FrNA();