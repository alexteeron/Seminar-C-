﻿// Задача №22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

String LineGen(int num)
{
    String res = String.Empty;
    int N = num;
    int pow = 2;
    for (int i = 1; i <= N; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}

int N = ReadData("Введите число N: ");
Console.WriteLine(LineGen);