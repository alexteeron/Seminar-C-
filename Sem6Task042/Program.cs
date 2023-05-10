// задача № 42
// Напишите программу, которая десятичное число переводит в двоичное.


Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int nam = int.Parse(Console.ReadLine() ?? "0");
    return nam;
}

String DecToBin(int nam)// метод преобразования из десятичной в двоичную систему исчисления
{                       // результат необходимо развернуть
    String res = String.Empty;
    while (nam > 0)
    {
        res = res + nam % 2;
        nam = nam / 2;
    }
    return res;
}
int nam = ReadData("введите число : ");
string binNam = DecToBin(nam);
Console.WriteLine(nam + " в двоичной системе = " + binNam);

Console.WriteLine(Convert.ToString(nam, 2)); //стандартная команда для преобразования с одной системы в другую
Console.WriteLine(Convert.ToString(nam, 8)); // = восьмиричную
Console.WriteLine(Convert.ToString(nam, 16));// = в шеснадцатиричную
Console.WriteLine(Convert.ToString(nam, 10));// = в десятичную