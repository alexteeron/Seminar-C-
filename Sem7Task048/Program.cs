// Задача № 48
// Напишите программу, которая создаем 2х мерный массив М*N, 
// каждый элемент в массиве находится по формуле A=M+N,
Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
int[,] FillMN(int countRow, int countColown)//метод создания 2х мерного массива 
{                                           //с заполнением по условию задачи
    int inIndexNam = 0;
    int[,] res = new int[countRow, countColown];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColown; j++)
        {
            inIndexNam = i+j;
            res[i, j] =inIndexNam; 
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
int count = ReadData("введите длинну строки : ");
int col = ReadData("введите длину столбца : ");
int[,] arr2D = FillMN(count,col);
Print2DArrey(arr2D);