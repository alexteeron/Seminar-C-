// Задача 41:
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями
//  и выдает сколько чисел больше 0 было введено.

Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int nam = int.Parse(Console.ReadLine() ?? "0");
    return nam;
}
//int CountPosNam(int nam)//Метод подсчета чисел больше "0" 
// {
//     int count = 0;
//     while (nam>0)
//     {
//         int val = ReadData("введите число : ");
//         if(val>0)count++;
//         nam--;
//     }
//     return count;
// }
// int nam = ReadData("введите количество чисел : ");
// int countPos = CountPosNam(nam);
// Console.WriteLine("количество чисел больше 0 = "+countPos);

//using System;
void Print1DArrey(int[] arr) //вывод данных
{                            //создаем тело в которое положим данные
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int CountPosNamKey(int len)
{
    ConsoleKeyInfo nam;//вводит в консоль нажатую клавишу
    Console.TreatControlCAsInput = true;// предотвращает выход с программы нажимая кнопки "Ctrl + C"

    string[] arr = new string[len];
    int count = 0;
    int N = 0;
    while (count < len)
    {
        nam = Console.ReadKey();
        NumberFormatInfo nam
        Console.WriteLine(N);
        if ((nam.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write(" + Alt");
        if ((nam.Modifiers & ConsoleModifiers.Control) != 0) Console.Write(" + Control");
        if ((nam.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write(" + Shift");
        Console.Write(" , ");//печать в консоль нажатой клавиши
        //int namConv = Convert.ToInt32(nam.Key);
        //if (namConv > 0) N++;
        // arr[count] = arr[count]+nam;
        // int i = Convert.ToInt32(arr[count]);
        // Console.WriteLine(i);
        // if(i>0)N++;
        // count++;
        //while (nam.Key != ConsoleKey.Escape) ;//выход из программы нажатием клавиши "Esc"
    }
    return N;
}
int nam = ReadData("введите количество нажатий : ");
Console.WriteLine();
int posNam = CountPosNamKey(nam);
Console.WriteLine("количество чисел > 0 было обнаруженно = " + posNam);
