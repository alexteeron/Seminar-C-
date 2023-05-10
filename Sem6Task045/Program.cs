// Задача № 45
// Напишите программу, которая будет создавать копию заданного одномерного массива
// с помощью поэлементного копирования

Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
int[] Gen1DArreyRnd(int len)//метод создания массива с заполнение случайными числами по данной длинне
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(100, 999);
    }
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
int[] CopyArrey(int[] arr)//метод копирования поэлементного копирования
{
    int[] res = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        res[i] = arr[i];
    }
    return res;
}
int len = ReadData("введите длинну массива : ");
int[] arrey = Gen1DArreyRnd(len);
Print1DArrey(arrey);//вывод заданного массива
int[] copyArrey = CopyArrey(arrey);
Print1DArrey(copyArrey);//вывод скопированного массива

// стандартный метод копирования
int[] outArrey = new int[arrey.Length];
arrey.CopyTo(outArrey,0);
Print1DArrey(outArrey);