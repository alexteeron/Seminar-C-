// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки, а затем найдите разницу между первым и последним элементом.

Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
double[] Gen1DArreyRnd(int len)//метод создания массива с заполнение случайными веществинными числами по данной длинне
{
    double[] res = new double[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(10, 99) + new Random().NextDouble(); //new Random().NextDouble()*100;
    }
    return res;
}
void Print1DArrey(double[] arr) //вывод данных
{                            //создаем тело в которое положим данные
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
double DiffMinMax(double[] arr)
{
    double res = 0;
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    return res = max - min;
}
void SortInputMetod(double[] arr)
{
    double max = 0;
    double input = 0;
    int j = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        input = arr[i];
        j = i;
        while (j > 0 && arr[j - 1] > input)
        {
            if (arr[i] > arr[j]) max = arr[i];
            if (arr[j] > arr[i]) max = arr[j];
            double temp = arr[j];
            arr[j] = arr[j - 1];
            arr[j - 1] = temp;
            j--;
        }
        arr[j] = input;
    }
    Console.WriteLine("разница между первым и последним элементом массива = " + (max - arr[0]));
}

int len = ReadData("введите длину массива : ");
double[] arrey = Gen1DArreyRnd(len);

Print1DArrey(arrey);
Console.WriteLine("разница между минимальным и максимальным значением массива : " + DiffMinMax(arrey));

SortInputMetod(arrey);
Print1DArrey(arrey);
