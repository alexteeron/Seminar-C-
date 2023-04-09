// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");

int namN = int.Parse(Console.ReadLine() ?? "0");
// Char[] masNam = namN.ToString().ToCharArray();

// if (namN < 100)
// {
//      Console.WriteLine("третьей цыфры нет");
// }
// else
// {
//     Char[] res = { masNam[2] };
//     Console.WriteLine(res);
// }

//* Сделать вариант для числа длиной до 10 цифр не используя char или string

if (namN < 100)
{
    Console.WriteLine("третьей цыфры нет");
}
else
{
    int res = namN;
    do
    {
        res = res / 10;
    } while (res >= 1000);

    res = res % 10;
    Console.WriteLine(res);
}