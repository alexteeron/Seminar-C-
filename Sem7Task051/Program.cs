// Задача № 51
// Задайте 2х мерный массив.
// Найдите сумму элементов находящихся на главной диагонали
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
            if (j % 2 == 0 && i % 2 == 0) Console.ForegroundColor = col[new Random().Next(0, 15)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
int SumNamDiagon(int[,] arr)//метод нахождения суммы в диагонали массива
{
    int sum = 0;
    //вводим тернарный оператор для предотвращении ошибки при разных индексах
    int len = (arr.GetLength(0) > arr.GetLength(1)) ? arr.GetLength(1): arr.GetLength(0);
    for (int i = 0; i < len; i++)
    {
        sum = sum + arr[i, i];
    }
    return sum;
}
int row = ReadData("введите длину строки : ");
int col = ReadData("введите длинну столбца : ");
int[,] arr = Gen2DArrey(row, col);
Print2DArrey(arr);  
int sum = SumNamDiagon(arr);
Console.WriteLine($"сумма элементов в диагонали массива = {sum}");