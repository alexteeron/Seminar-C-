// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// *Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1).
Console.Clear();
int ReadData(string msg)  //ввод тданных
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void Print1DArrey(int[] arr) //вывод данных
{                            //создаем тело в которое положим данные
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int[] Gen1DArrey(int len, int top, int but) //метод заполненния 
{                                           //случайными числами
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}
int arrey = ReadData("введите число : ");
int[] arreyIn = Gen1DArrey(arrey, 1, 0);
Print1DArrey(arreyIn);

string ReadDataName(string msg)  //ввод тданных
{
    Console.WriteLine(msg);
    string res = Console.ReadLine();
    return res;
}

void PrintName(string a, string b)
{
    Console.Write(a);
    Console.WriteLine(b);
}
string[] NameRandom(string[] name)
{
    string.Split(new char[name] { ' ', ',' });
    string[] res = new Random().Next(1,name.Length+1);
    return res[N];
}
string name = ReadDataName("введите имена : ");
string[] res = NameRandom(name);
PrintName("выбранно имя : ", res[res]);