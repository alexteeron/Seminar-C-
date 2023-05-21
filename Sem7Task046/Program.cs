// задача 46
// задайте 2х мерный массив с размером M*N и заполненный случайными числами

Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
int[,] Gen2DArreyRnd(int countRow, int countColown)//метод создания массива с заполнение случайными числами по данной длинне
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
            Console.ForegroundColor = col[new Random().Next(0,15)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
int row = ReadData("введите количество строк : ");
int colown = ReadData("введите количество столбцов : ");
int[,] arr = Gen2DArreyRnd(row, colown);
Print2DArrey(arr);