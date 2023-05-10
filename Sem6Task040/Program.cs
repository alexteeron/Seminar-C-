//Задача № 40
// Напишите программу, которая принимает на вход 3 числа
// и проверяет, может ли существовать треугольник со сторонами такой длинны

Console.Clear();
int ReadData(string mess)//ввод данных
{
    Console.Write(mess);
    int nam = int.Parse(Console.ReadLine() ?? "0");
    return nam;
}

int nam1 = ReadData("введите первое число : ");
int nam2 = ReadData("введите второе число : ");
int nam3 = ReadData("введите третье число : ");

void TrianTest(int a, int b, int c)//Метод проверки, подлинности треугольника
{
    if ((a <= b + c) && (b <= c + a) && (c <= a + b))
    {
        Console.WriteLine("Треугольник существует");
    }
    else
    {
        Console.WriteLine("Треугольник не существует");
    }
}

TrianTest(nam1, nam2, nam3);//вывод метода