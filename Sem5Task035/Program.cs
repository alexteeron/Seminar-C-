//Задача № 35
//Задайте одномерный массив из 123 случайных чисел
//Найдите количество элементов массива, значение которых лежат в отрезке от 10 до 99

Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
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
int[] Gen1DArreyRnd(int len)
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
void SerchArrNam(int[] arr)//метод нахождения отрезка внутри массива
{
    
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i >= 10 && i <= 99)
        {
            count++;
           
        }
    }
    Console.WriteLine("длинна отрезка " + count + " элементов");
}
int ElemInRenge(int[] arr, int min,int max)//метод нахождения количество элементов внутри массива 
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=min && arr[i]<=max)
        res++;
    }
    return res;
}
int len = ReadData("введите длину массива : ");
int[] arr = Gen1DArreyRnd(len);
Print1DArrey(arr);
SerchArrNam(arr);
Console.WriteLine("количество элементов  : "+ (ElemInRenge(arr,10,99)));