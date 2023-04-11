// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом
Console.Clear();
int ReadData(string mass)
{
    Console.Write(mass);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintAnsver(int N, string mass)
{
    Console.Write(mass);
    Console.WriteLine(N);
}
string NamCub(int namN, int pow)
{
    string res = string.Empty;
    for (int i = 1; i <= namN; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}
int namN = ReadData("введите число : ");

Console.WriteLine(NamCub(namN,1));
Console.WriteLine(NamCub(namN,3));

