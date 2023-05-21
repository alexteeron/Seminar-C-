// Задача 50.
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
// Например, задан массив:
Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int arrey = int.Parse(Console.ReadLine() ?? "0");
    return arrey;
}
long[,] Gen2DArrey(int countRow, int countColown)//метод создания массива с заполненым цыфрами фабиновича 
{
    long[,] res = new long[countRow, countColown];
    int first = 0;
    int last = 1;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColown; j++)
        {
            res[i, j] += last + first;
            (first, last) = (last, last + first);
            // Console.WriteLine(first + " " + last);
        }
    }
    return res;
}
void Print2DArrey(long[,] arr, int x, int y) //вывод данных
{                           
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == x && j == y)//выделение нужного элемента в цвет
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
void FindElem(long[,] arr, int x, int y)//метод вывода элемента по заданным индексам
{
    if (x > arr.GetLength(0) || y > arr.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.Write($"'элемент индеков {(x, y)} = ");
        Console.ForegroundColor = ConsoleColor.Blue;//покраска ответа
        Console.WriteLine(arr[x, y]);
        Console.ResetColor();
    }
}
int x = ReadData("введите x = ");
int y = ReadData("введите y = ");
long[,] arr = Gen2DArrey(10, 10);
FindElem(arr, x, y);
Print2DArrey(arr, x, y);