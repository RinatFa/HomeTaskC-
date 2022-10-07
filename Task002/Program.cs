// 2. Даны два числа. Показать большее и меньшее число

int max = 0;
int min = 0;
int numberA = 5;
int numberB = 7;
if (numberA > numberB){
    max = numberA;
    min = numberB;
}
else{
    max = numberB;
    min = numberA;
}
Console.WriteLine("Большее число = " + max);
Console.WriteLine("Меньшее число = " + min);