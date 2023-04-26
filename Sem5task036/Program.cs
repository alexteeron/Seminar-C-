// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//* Найдите все пары в массиве и выведите пользователю
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
        res[i] = new Random().Next(0, 10);
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
int SumPozitivNam(int[] arr)//метод нахождения суммы чётных чисел
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res += arr[i];
    }
    return res;
}
void TwinsNamArr(int[] arr)// метод нахождения парных цыфр в массиве, без повторений
{
    int count=1;
    for (int i = 0; i < arr.Length-1; i++)
    {
        for (int j=count;j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                Console.Write(arr[i] + " , " + arr[j] + " - [" + i + "] , [" + j + "] ; ");
                arr[j]=arr[i]-10;
                break;
            }
        }
        count++;
    }
}
int len = ReadData("введите длину массива : ");// получение данных
int[] arrey = Gen1DArreyRnd(len);//заполняем массив
Print1DArrey(arrey);//печатаем массив
Console.WriteLine("сумма четных чисел массива = " + SumPozitivNam(arrey));//получаем сумму чётных чисел массива
TwinsNamArr(arrey);//находим пары массива