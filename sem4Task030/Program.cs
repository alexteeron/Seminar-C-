// Задача №30
// напишите программу которая выдает массив 
// заполненный случайными числами(0,1)

int ReadData(string msg)  //ввод тданных
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void Print1DArrey(int[] arr) //вывод данных
{                            //создаем тело в которое положим данные
    Console.Write("["); Console.Clear();


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