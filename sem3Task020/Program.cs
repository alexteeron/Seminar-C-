﻿// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

        // // Запрос координат первой точки
        // Console.WriteLine("Введите координаты первой точки:");
        // Console.Write("X1: ");
        // double x1 = double.Parse(Console.ReadLine());
        // Console.Write("Y1: ");
        // double y1 = double.Parse(Console.ReadLine());

        // // Запрос координат второй точки
        // Console.WriteLine("Введите координаты второй точки:");
        // Console.Write("X2: ");
        // double x2 = double.Parse(Console.ReadLine());
        // Console.Write("Y2: ");
        // double y2 = double.Parse(Console.ReadLine());

        // // Вычисление расстояния между двумя точками
        // double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        // // Вывод результата
        // Console.WriteLine("Расстояние между двумя точками: {0}", distance);
    
// 
Console.Clear();
double ReadData(string mess)
{
    Console.WriteLine(mess);
    double res = double.Parse(Console.ReadLine()??"0");
    return res;
}
void PrintWrite(string mess, double distanse)
{
    Console.Write(mess);
    Console.WriteLine(distanse);
}
double x1 = ReadData("введите координаты первой точки х1 = ");
double y1 = ReadData("введите координаты первой точки y1 = ");
double x2 = ReadData("введите координаты первой точки х2 = ");
double y2 = ReadData("введите координаты первой точки y2 = ");

double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
PrintWrite("расстояние между точками ", distance);