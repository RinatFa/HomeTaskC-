// Задача 13: ВАРИАНТ ОТСЧЕТА ОТ ЛЕВОГО КРАЯ ЧИСЛА
// Напишите метод, который выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 (!)
// 78 -> третьей цифры нет
// 32679 -> 6

// 1. ввод значений
int GetValue(){
    Console.Write("Введите число = ");
    int iNumb = Convert.ToInt32(Console.ReadLine());
    return iNumb;           
}
// 2. вычисление
void DivMod3FrN(){
    int numberA  = GetValue();
    int numberB = 0;
    int numberC = 0;
    int Divider = 10;
    int count = 0;
    int count2 = 0;
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
        if (count == 3){
            numberB = numberA % 10;
        }
        else{
            Divider = 10;
            count2 = 1;     // для (count > 3)
            while (count2 < count - 3){    
                Divider = Divider * 10;       
                count2 += 1;
            }   // определение количества нулей в Divider
            numberB = numberA / Divider % 10;
        }
        sStr = "Третья цифра числа " + Convert.ToString(numberC) + 
            " равна " + Convert.ToString(numberB) + 
            "  (отчет от левого края числа)";
    }
    Console.WriteLine(sStr);
}

DivMod3FrN();