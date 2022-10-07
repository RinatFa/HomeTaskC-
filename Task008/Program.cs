// 8. Найти все чётные числа от 1 до N.

int numberA = 1;
Console.Write("Введите максмальное число = ");
int max = Convert.ToInt32(Console.ReadLine());
while(numberA <= max){
    if (numberA % 2 == 0){
        Console.Write(numberA + " ");
    }  
    numberA += 1;
}
Console.WriteLine("");