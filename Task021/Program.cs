// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetValue(string text){
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print(double ax, double ay, double az, double bx, double by, double bz, double result){
    double res = Math.Round(result, 2);
    string output = $"|A({ax}, {ay}, {az}); B({bx}, {by}, {bz})| = {res}";
    Console.WriteLine(output);
}

double GetDistance(double ax, double ay, double az, double bx, double by, double bz){
    return Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by) + (az - bz) * (az - bz));
}

double ax = GetValue("ax");
double ay = GetValue("ay");
double az = GetValue("az");
double bx = GetValue("bx");
double by = GetValue("by");
double bz = GetValue("bz");
double dis = GetDistance(ax, ay, az, bx, by, bz);
Print(ax, ay, az, bx, by, bz, dis);