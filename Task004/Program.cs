// 4. Найти максимальное из трех чисел

int max = 0;
int numberA = 2;
int numberB = 3;
int numberC = 7;
if (numberA > numberB){
    max = numberA;
}
else{
    max = numberB;
}
if (max < numberC) max = numberC;
Console.WriteLine("Максимальное число из трех = " + max);