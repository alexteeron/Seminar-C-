// Задача №28
// Напишите программу которая принимает число
// и выдает произведение его чисел

using System.Numerics; // необходимая команда для работы BigInteger
                       // без нее этот тип не будет работать
Console.Clear();
int ReadData(string msg)  //ввод тданных
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintAnsver(string mess, BigInteger nam) //вывод данных
{
    Console.Write(mess);
    Console.WriteLine(nam);
}
BigInteger Factorial(int nam)
{
    BigInteger res = 1;
    for (int i = 1; i <= nam; i++)
    {
        res = res*i;
    }
    return res;
}
int namF = ReadData("введите число : ");
BigInteger result = Factorial(namF);
PrintAnsver(" факториал числа ", result);