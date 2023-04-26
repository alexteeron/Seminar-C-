// Задача № 37
//Найдите произведение пар чисел в одномерном массиве
//пары считаются первый и последний элемент
//результат запишите в новы массив
Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
int[] Gen1DArrey(int len, int but, int top) //метод заполненния 
{                                           //случайными числами
    if (but > top)
    {
        int buf = but;
        but = top;
        top = buf;
    }
    Random rnd = new Random(); 
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = rnd.Next(but, top + 1);
    }
    return res;
}
int[] Gen1DArreyRnd(int len)//метод создания массива с заполнение случайными числами по данной длинне
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(0, 999);
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
void SumRevArrey(int[] arr, int[] sumArr, int len)//метод произведения крайних значений масива 
{                                                 //сдвигаясь к середине

    for (int i = 0; i < len; i++)
    {
        sumArr[i] = arr[i] * arr[arr.Length-1-i];
    }
}
int namLength = ReadData("введите длину массива : ");//вызов метода
int sumLength = (namLength %2==0)? namLength/2:namLength/2+1;//создание длинны массива 1/2 длинны заданного
int[] arrey = Gen1DArreyRnd(namLength);//создание заданного массива
int[] sumArr = Gen1DArreyRnd(sumLength);//создание массива для заполнения
Print1DArrey(arrey);//печать заданного массива
Print1DArrey(sumArr);//печать массива для заполнения
SumRevArrey(arrey, sumArr, sumLength);//заполнение массива произведением пар
Print1DArrey(sumArr);//печать заполненного массива
