// Задача 25: Напишите цикл,
//  который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

Console.Clear();
double ReadData(string msg)  //ввод данных
{
    Console.WriteLine(msg);
    double res = double.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintAnsver(string mess, double nam) //вывод данных
{
    Console.Write(mess);
    Console.WriteLine(nam);
}

double CalkNam(double a, char b)//метод возведения в степень(работает только с однозначной степенью)
{                                                                       
    int d = 1;
    char c = '2';
    for (c = '2'; c <= b; c++)
    {
        d = d + 1;
    }
    double res = a;
    for (int i = 1; i < d; i++)
    {
        res *= a;
        Console.WriteLine(res);
    }
    return res;
}

double CalkUser(double a, double b, char c)//Метод арифметического действия
{
    double res = 0;
    if (c == '+') res = a + b;
    if (c == '-') res = a - b;
    if (c == '*') res = a * b;
    if (c == '/') res = a / b;

    return res;
}

double a = ReadData("введите первое число : ");
Console.Write("введите арифметическое действие, или в какую степень возвести :");
char namN = char.Parse(Console.ReadLine() ?? "0");
if (namN == '+' || namN == '-' || namN == '*' || namN == '/')//проверка второго значения,
{                                                            //арифметическое действие или   
    double b = ReadData("введите второе число : ");          //возведение в степень
    double result = CalkUser(a, b, namN);
    PrintAnsver("результат : ", result);
}
else
{
    double result = CalkNam(a, namN);
    PrintAnsver("результат : ", result);
}

// double namB = ReadData("в какую степень возвести : ");
// double result = CalkNam(namA, namB);

