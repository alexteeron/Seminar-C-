// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
Console.Clear();
int ReadData(string messege)
{
    Console.WriteLine(messege);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintAnsver(int nam, string mess)
{
    Console.Write(mess);
    Console.WriteLine(nam);
}
// bool PolCall(int namP)
// {
//     bool res = false;
//     int d1 = namP / 10000;
//     int d2 = (namP / 1000) % 10;
//     int d4 = (namP / 10) % 10;
//     int d5 = namP % 10;
//     if (d1 == d5 && d2 == d4)
//         res = true;
//     return res;
// }
// int namP = ReadData("введите число : ");
// if (PolCall(namP))
// {
//     PrintAnsver(namP, "полиндром ");
// }
// else
// {
//     PrintAnsver(namP, "не полиндром ");
// }
// работа со словарем*
Dictionary<int, string> PolCall = new Dictionary<int, string>();
PolCall.Add(1111, "полиндром");
PolCall.Add(2112, "полиндром");
PolCall.Add(3113, "полиндром");
PolCall.Add(4114, "полиндром");
PolCall.Add(5115, "полиндром");
PolCall.Add(6116, "полиндром");
PolCall.Add(7117, "полиндром");
PolCall.Add(8118, "полиндром");
PolCall.Add(9119, "полиндром");
PolCall.Add(1221, "полиндром");
PolCall.Add(1331, "полиндром");
PolCall.Add(1441, "полиндром");
PolCall.Add(1551, "полиндром");
PolCall.Add(1661, "полиндром");
PolCall.Add(1771, "полиндром");
PolCall.Add(1881, "полиндром");
PolCall.Add(1991, "полиндром");
PolCall.Add(1001, "полиндром");
PolCall.Add(2222, "полиндром");
PolCall.Add(3223, "полиндром");
PolCall.Add(4224, "полиндром");
PolCall.Add(5225, "полиндром");
PolCall.Add(6226, "полиндром");
PolCall.Add(7227, "полиндром");
PolCall.Add(8228, "полиндром");
PolCall.Add(9229, "полиндром");
PolCall.Add(2332, "полиндром");
PolCall.Add(2442, "полиндром");
PolCall.Add(2552, "полиндром");
PolCall.Add(2662, "полиндром");
PolCall.Add(2772, "полиндром");
PolCall.Add(2882, "полиндром");
PolCall.Add(2992, "полиндром");
PolCall.Add(3333, "полиндром");
PolCall.Add(4334, "полиндром");
PolCall.Add(5335, "полиндром");
PolCall.Add(6336, "полиндром");
PolCall.Add(7337, "полиндром");
PolCall.Add(8338, "полиндром");
PolCall.Add(9339, "полиндром");
PolCall.Add(3443, "полиндром");
PolCall.Add(3553, "полиндром");
PolCall.Add(3663, "полиндром");
PolCall.Add(3773, "полиндром");
PolCall.Add(3883, "полиндром");
PolCall.Add(3993, "полиндром");
PolCall.Add(3003, "полиндром");
PolCall.Add(4444, "полиндром");
PolCall.Add(5445, "полиндром");
PolCall.Add(6446, "полиндром");
PolCall.Add(7447, "полиндром");
PolCall.Add(8448, "полиндром");
PolCall.Add(9449, "полиндром");
PolCall.Add(4554, "полиндром");
PolCall.Add(4664, "полиндром");
PolCall.Add(4774, "полиндром");
PolCall.Add(4884, "полиндром");
PolCall.Add(4994, "полиндром");
PolCall.Add(4004, "полиндром");
PolCall.Add(5555, "полиндром");
PolCall.Add(6556, "полиндром");
PolCall.Add(7557, "полиндром");
PolCall.Add(8558, "полиндром");
PolCall.Add(9559, "полиндром");
PolCall.Add(5665, "полиндром");
PolCall.Add(5775, "полиндром");
PolCall.Add(5885, "полиндром");
PolCall.Add(5995, "полиндром");
PolCall.Add(5005, "полиндром");
PolCall.Add(6666, "полиндром");
PolCall.Add(7667, "полиндром");
PolCall.Add(8668, "полиндром");
PolCall.Add(9669, "полиндром");
PolCall.Add(6776, "полиндром");
PolCall.Add(6886, "полиндром");
PolCall.Add(6996, "полиндром");
PolCall.Add(6006, "полиндром");
PolCall.Add(7777, "полиндром");
PolCall.Add(8778, "полиндром");
PolCall.Add(9779, "полиндром");
PolCall.Add(7887, "полиндром");
PolCall.Add(7997, "полиндром");
PolCall.Add(7007, "полиндром");
PolCall.Add(8888, "полиндром");
PolCall.Add(9889, "полиндром");
PolCall.Add(8998, "полиндром");
PolCall.Add(8008, "полиндром");
PolCall.Add(9999, "полиндром");
PolCall.Add(9009, "полиндром");
int polArr = ReadData("введите пятизначное число : ");
// char[] pol = polArr.ToString().ToCharArray();
// char[] a = { pol[0] };
// char[] b = { pol[1] };
// char[] c = { pol[3] };
// char[] d = { pol[4] };
// int namP = (a*10000)+(b*1000)+(c*10)+d;
int removeNam(int namP) // Метод удаления числа
{
    int a = polArr / 1000;
    int b = polArr % 100;
    int c = polArr % 10;
    int res = a * 100 + b;
    return res;
}
int namP = removeNam(polArr);
PrintAnsver(namP, " проверка "); // проверка получаемого числа
if (polArr < 10000 || polArr >= 100000)
{
    PrintAnsver(polArr, " ввели не верное число");
}
else
{    
    if (PolCall.ContainsKey(namP)) PrintAnsver(polArr, "полиндром : ");//метод вывода
    else
    {
        PrintAnsver(polArr, " не полиндром : ");
    }
}