//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число");
string? InLine = Console.ReadLine();


if (InLine != null)
{

    int N = int.Parse(InLine);

    if (N % 2 == 0)
    {
        Console.WriteLine("чётное");
    }

    else
    {
        Console.WriteLine("не чётное");
    }

}

