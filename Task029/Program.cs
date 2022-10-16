// Задача 29: Напишите метод, который задаёт массив
//  из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string InputOutArray(){
    int length = 8;
    int[] array = new int[length];
    for (int iCount = 0; iCount < length; iCount++){
        Console.Write("Введите число (остановка ввода: -1 ) = ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        if (numberA == -1){
            break;
        }
        else{
            array[iCount] = numberA;
        }
    }
    string sStr = "[ " + array[0];
    for (int iCount = 1; iCount < length; iCount++){
            if (array[iCount] == 0){
            break;
        }   //выход из цикла, если 0, т.е. не ввели значение
        else{
            sStr = sStr + ", " + array[iCount];
        }
    }
    sStr = sStr + " ]";
    return sStr;
}

string sString = InputOutArray();
Console.WriteLine(sString);
