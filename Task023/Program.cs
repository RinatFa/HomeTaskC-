// Задача 23: Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int numberA = 1;
int numberB = 1;
Console.Write("Введите максмальное число = ");
int max = Convert.ToInt32(Console.ReadLine());
while(numberA <= max){
    numberB = numberA * numberA * numberA;
    Console.Write(numberB + " ");
    numberA += 1;
}
Console.WriteLine("");