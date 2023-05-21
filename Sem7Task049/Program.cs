// Задача № 49
// Задайте 2х мерный массив, найдите элементы, у которых оба индекса четные
// и замените эти элементы на их квадраты
Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
int[,] Gen2DArrey(int countRow, int countColown)//метод создания 2х мерного массива с заполнением случайными числоми
{
    int[,] res = new int[countRow, countColown];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColown; j++)
        {
            res[i, j] = new Random().Next(100, 999);
        }
    }
    return res;
}
void SqrtPosNamIndex(int[,] arr)//метод возведения в квадрат всех обоюдно четных индексов массива
{
    for (int i = 0; i < arr.GetLength(0); i = i + 2)//проход по строке массива
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)//проход по столбу массива
        {
            arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }
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
int row = ReadData("введите длину строки : ");
int col = ReadData("введите длинну столбца : ");
int[,] arrSqrt2D = Gen2DArrey(row, col);
Print2DArrey(arrSqrt2D);
SqrtPosNamIndex(arrSqrt2D);
Print2DArrey(arrSqrt2D);