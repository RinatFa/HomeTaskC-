// Задача 19: Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1. ввод значений
int GetValue(){
  Console.Write("Введите пятизначное число = ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  return numberA;
}
// 2. вычисление
string Palindrome(int numberA){
  int result = 0;
  string sStr = "";
  int numberB = 0;
  int numberC = numberA;
  while (numberA != 0){
    numberB = numberA % 10;
    result = result * 10 + numberB;
    numberA = numberA / 10;
  }    // разворот числа
  if (result == numberC){
    sStr = "Число является палиндромом!";
  }
  else{
    sStr = "Число не является палиндромом!";
  }
  return sStr;
}

int numberA = GetValue();
string sString = Palindrome(numberA);
Console.WriteLine(sString);