// Задача 41:
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями
//  и выдает сколько чисел больше 0 было введено.

using System.Text.RegularExpressions;//обращение в систему для работы регулярного выражения
Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int nam = int.Parse(Console.ReadLine() ?? "0");
    return nam;
}

//     ConsoleKeyInfo nam;//вводит в консоль нажатую клавишу
//     Console.TreatControlCAsInput = true;// предотвращает выход с программы нажимая кнопки "Ctrl + C"

//     string[] arr = new string[len];
//     int count = 0;
//     int N = 0;
//     while (count < len)
//     {
//         NumberFormatInfo nam; nam = Console.ReadKey();
//         Console.WriteLine(N);
//         if ((nam.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write(" + Alt");
//         if ((nam.Modifiers & ConsoleModifiers.Control) != 0) Console.Write(" + Control");
//         if ((nam.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write(" + Shift");
//         Console.Write(" , ");//печать в консоль нажатой клавиши
//         //while (nam.Key != ConsoleKey.Escape) ;//выход из программы нажатием клавиши "Esc"
//     }
//     return N;
// }
string ReadLineData(string msg, int tabs)
{
    Console.WriteLine(msg);
    String line = "";
    for (int i = 0; i < tabs; i++)
    {
        var key = Console.ReadKey(true);
        line = line + String.Format(key.KeyChar.ToString())+ ",";
    }
    line = line.TrimEnd(',');
    return line;
}
void FindNamInString(string line,int tabs)//метод для поиска десятичных цифр с помощью регулярных выражений
{
    Regex regex = new Regex(@"\d");//параметр для поиска десятичных цифр
    MatchCollection matches = regex.Matches(line);//создаем коллекцию для 
    int posNam = 0;
    if(matches.Count>0)
    {
        foreach(Match match in matches)
        {
            posNam++;
        }
        Console.WriteLine($"вы совершили нажатий: {tabs}. Среди введенных цифр найденно цифр: {posNam}");
    }
    else
    {
        Console.WriteLine($"вы совершили нажатий: {tabs}. Среди введенных цифр найденно цифр: {posNam}");
    }
}
int nam = ReadData("введите количество нажатий : ");
string line = ReadLineData("введите любые символы с клавиатуры : ",nam);
Console.WriteLine(line);
FindNamInString(line,nam);
//int posNam = CountPosNamKey(nam);
//Console.WriteLine("количество чисел > 0 было обнаруженно = " + posNam);
