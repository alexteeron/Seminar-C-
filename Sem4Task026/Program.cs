//Задача №26
//напишите программу, которая принимает на вход число
//и показывает сколько чисел в числе


Console.Clear();
int ReadData(string msg)  //ввод тданных
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintAnsver(string mess, long nam) //вывод данных
{
    Console.Write(mess);
    Console.WriteLine(nam);
}
int CountDigit(int nam) // метод подсчета количества цифр в заданном числе
{
    int result = 0;
    while (nam > 0)
    {
        result = result + 1;
        nam = nam / 10;
    }
    return result;
}
int namA = ReadData("введите число : ");
int resNam = CountDigit(namA);
PrintAnsver("количество чисел : ",+resNam);