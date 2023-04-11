// Задача №22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.Clear();
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

String LineGen(int nam, int pow)
{
    String res = String.Empty;
    
    for (int i = 1; i <= nam; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}

int nam= ReadData("Введите число N: ");

Console.WriteLine(LineGen(nam,1));
Console.WriteLine(LineGen(nam,2));