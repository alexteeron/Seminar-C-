//Задача №33
//Задайте массив
//Напишите программу которая определяет, присутствует ли заданное число в массиве

Console.Clear();
int ReadData(String mess)
{
    Console.WriteLine(mess);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

int[] Gen1DArrey(int len, int but, int top) //метод заполненния 
{
    if (but > top)
    {
        int buf = but;
        but = top;
        top = buf;
    }
    Random rnd = new Random();                                       //случайными числами
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = rnd.Next(but, top + 1);
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

void ComperitionArr(int[] arr, int nam)// метод поиска совпадений в массиве
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == nam)
        {
            res++;
            Console.WriteLine("совпадение : в " + i + " ячейке");
        }
    }
    if (res == 0) Console.WriteLine("совпадений не найдено");
}

int nam = ReadData("введите число : ");
int[] arrey = Gen1DArrey(15, 0, 10);
Print1DArrey(arrey);
ComperitionArr(arrey, nam);
