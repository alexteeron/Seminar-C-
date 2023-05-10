// Задача № 43: Напишите программу,
//  которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
//  *Найдите площадь треугольника образованного пересечением 3 прямых

Console.Clear();
double ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    double nam = double.Parse(Console.ReadLine() ?? "0");
    return nam;
}
void PrintAnsver(string a, double b)//метод вывода данных
{
    Console.Write(a);
    Console.WriteLine(b);
}
double DistanseLine(double x1, double y1, double x2, double y2)//метод расчета длинны отрезка
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return res;
}
//ввод даных
double b1 = ReadData("введите b1 = ");
double k1 = ReadData("введите k1 = ");
double b2 = ReadData("введите b2 = ");
double k2 = ReadData("введите k2 = ");
double b3 = ReadData("введите b3 = ");
double k3 = ReadData("введите k3 = ");
//находим точки координат
double x1 = -(b1 - b2) / (k1 - k2);
double y1 = k1 * x1 + b1;
double x2 = -(b1 - b3) / (k1 - k3);
double y2 = k2 * x2 - b2;
double x3 = -(b2 - b3) / (k2 - k3);
double y3 = k3 * x3 - b3;
//печать полученных координат
Console.WriteLine($"[{x1},{y1}]");
Console.WriteLine($"[{x2},{y2}]");
Console.WriteLine($"[{x3},{y3}]");
//получаем длинну отрезка
double line1 = DistanseLine(x1, y1, x2, y2); Console.WriteLine(line1);
double line2 = DistanseLine(x1, y1, x3, y3); Console.WriteLine(line2);
double line3 = DistanseLine(x2, y2, x3, y3); Console.WriteLine(line3);

double p = (line1+line2+line3)/2;//получаем полупериметр треугольника
double triangArea = Math.Sqrt(p*(p-line1)*(p-line2)*(p-line3));//получаем площадь треугольника по формуле Герона
//печать данных
PrintAnsver("площадь треугольника = ", triangArea);