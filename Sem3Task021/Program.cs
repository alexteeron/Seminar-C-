// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
double ReadData(string messege)
{
    Console.WriteLine(messege);
    double res = double.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintAnsver(double nam, string mess)
{
    Console.Write(mess);
    Console.WriteLine(nam);
}
double x1 = ReadData("введите координату x1 : ");
double y1 = ReadData("введите координату y1 : ");
double z1 = ReadData("введите координату z1 : ");
double x2 = ReadData("введите координату x2 : ");
double y2 = ReadData("введите координату y2 : ");
double z2 = ReadData("введите координату z2 : ");
double res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
PrintAnsver(res, " расстояние между точками :");