// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// * Отсортировать массив методом пузырька и подсчета.
// Сравнить быстродействие методов. Проверку сортировки производить отдельно.
// Сначало запустить программу с одним методом сортировки,
// а затем с другим. Проверять на длине массива не мение 10000 элементов.
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
int QuantPosElem(int[] arrey)
{
    int res = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] % 2 == 0) res++;
    }
    return res;
}
int[] BubleSort(int[] arr)//метод сортировки пузырьком
{
    int[] bublSort = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
            
        }
        
    }
    bublSort=arr;
    return bublSort;
}
int[] CountSortMetod(int[] arr)//метод сортировки подсчетом
{
    int[] sortAr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] > arr[j]) count++;
        }
        //Console.Write(" [" + arr[i] + "," + count + "] ");
        sortAr[count] = arr[i];
    }
    return sortAr;
}
int len = ReadData("введите длину массива : ");
int[] arrey = Gen1DArreyRnd(len);

Print1DArrey(arrey);
DateTime d1 = DateTime.Now;
int[] bublSort = BubleSort(arrey);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int[] sortAr = CountSortMetod(arrey);
Console.WriteLine(DateTime.Now - d2);

Print1DArrey(bublSort);
Print1DArrey(sortAr);
Console.WriteLine("количество четных чисел в массиве : " + QuantPosElem(arrey));