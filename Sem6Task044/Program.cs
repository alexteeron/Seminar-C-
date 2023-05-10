// Задача № 44
// не используя рекурсию, выведите N чисел,ипользуя первые 2 чисел Фиббоначи.

Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int nam = int.Parse(Console.ReadLine() ?? "0");
    return nam;
}

String FibNam(int nam)// метод выводв чисел Фиббоначи
{
    String res="0 1";
    long first=0;
    long last =1;
    for (int i = 2; i < nam; i++)
    {
        res=res+" "+(first+last);
        (first,last)=(last,last+first);
    }
    return res;
}
int nam = ReadData("введите число N :");
Console.WriteLine(FibNam(nam));