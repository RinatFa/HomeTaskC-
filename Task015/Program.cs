// Задача 15: Напишите метод, который принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// 1. ввод значений
int GetValue(){
    Console.Write("Введите число дня недели = ");
    int iNumb = Convert.ToInt32(Console.ReadLine());
    return iNumb;           
}
// 2. вычисление
void Weekend67Fr7(){
    int numberA  = GetValue();
    string sStr = "";
    if ((numberA > 0) & (numberA < 6)){
        sStr = "Рабочий день";
    }
    if ((numberA == 6) | (numberA == 7)){
        sStr = "Выходной день";
    }
    if ((numberA > 7) | (numberA < 1)){
        sStr = "Число дня недели может быть только от 1 до 7 !";
    }
    Console.WriteLine(sStr);
}

Weekend67Fr7();