// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно диагональ выделить разным цветом.
Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
int[,] Gen2DArrey(int countRow, int countColown)//метод создания массива с заполнение случайными числами по данной длинне
{
    int[,] res = new int[countRow, countColown];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColown; j++)
        {
            res[i, j] = new Random().Next(10, 99);
        }
    }
    return res;
}
void Print2DArrey(int[,] arr) //вывод данных
{                            //создаем тело в которое положим данные
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.Green,
                             ConsoleColor.Magenta,ConsoleColor.Yellow,ConsoleColor.White,ConsoleColor.Red,
                             ConsoleColor.Gray,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkMagenta,
                             ConsoleColor.DarkGreen,ConsoleColor.DarkYellow,ConsoleColor.DarkRed,ConsoleColor.DarkGray};
    //убрали черный цвет, так как в консоли его не видно  
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == i) Console.ForegroundColor = col[new Random().Next(0, 15)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
void ArifMeanArreyCol(int[,] arr)//Метод нахождения среднего арифметического каждого столбца массива
{
    Console.WriteLine("среднее арифметическое столбца, каждого индекса строки массива:");
    double[] arifmeat = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int count = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            arifmeat[i] += arr[j, i];
            count++;
        }
        arifmeat[i] = arifmeat[i] / count;
        Console.Write("[" + i + "]" + arifmeat[i] + " ");
    }
}
int len = ReadData(" введите количество строк - ");
int col = ReadData("введите количество столбцов - ");
int[,] arr = Gen2DArrey(len, col);
Print2DArrey(arr);
ArifMeanArreyCol(arr);