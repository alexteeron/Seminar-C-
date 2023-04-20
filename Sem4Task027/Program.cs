// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int ReadData(string msg)  //ввод тданных
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintAnsver(string mess, int nam) //вывод данных
{
    Console.Write(mess);
    Console.WriteLine(nam);
}
int SumNamb(int a)//метод суммы чисел в заданном числе
{
    int res = 0;

    while (a > 0)
    {
        int namA = a % 10;
        res += namA;
        a = a / 10;
    }
    return res;
}
int N = ReadData("введите число : ");
int result = SumNamb(N);
PrintAnsver("результат : ", result);