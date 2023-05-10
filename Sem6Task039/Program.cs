//Задача №39
// Напишите программу которая перевернет одномерный массив,
// последний элемент на первом месте, а первый на последнем

Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
int[] Gen1DArreyRnd(int len)//метод создания массива с заполнение случайными веществинными числами по данной длинне
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(10, 99); //new Random().Nex int()*100;
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
void SwopArrey(int[] arr)// метод разворота массива
{
    int buf=0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        //(arr[i],arr[arr.Length-1-i])=(arr[arr.Length-1-i],arr[i]); новый метод, не работает на старых компьютерах
        buf = arr[i];
        arr[i]=arr[arr.Length-1-i];
        arr[arr.Length-1-i]=buf;
    }
}

int[] SwopNewArrey(int[] arr)
{
    int[] outArr =new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[outArr.Length-1-i]=arr[i];
    }
    return outArr;
}

int len = ReadData("введите длину массива : ");
int[] arrey = Gen1DArreyRnd(len);
Print1DArrey(arrey);
SwopArrey(arrey);
Print1DArrey(arrey);
Print1DArrey(SwopNewArrey(arrey));