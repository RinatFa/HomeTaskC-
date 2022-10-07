// 6. Определить, является ли число чётным.

int numberA = 4;
string sStr = " ";
if(numberA % 2 == 0){
    sStr = "Число " + Convert.ToString(numberA) + " четное";
}
else{
    sStr = "Число " + Convert.ToString(numberA) + " нечетное";
}
Console.WriteLine(sStr);