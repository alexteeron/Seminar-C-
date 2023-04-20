//задача 24
//Напишите программу которая принимает число А
// и выдает сумму чисел от 0 до А
Console.Clear();
int ReadData(string msg)  //ввод тданных
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintAnsver(long nam, string mess) //вывод данных
{
    Console.Write(mess);
    Console.WriteLine(nam);
}
long SumNam(int a)  //метод сложения чисел от 1 до заданного числа
{
    long res = 0;
    int count = 0;
    long sum = 0;
    while (count < a)
    {
        res = res + 1;
        // Console.Write(res);
        sum = sum + res;
        count++;
    }
    return sum;
}
long SumGaus(int a) //метод сложения чисел по формеле Гауса
{
    return ((1 + (long)a) * (long)a) / 2;
}
int sum = ReadData("введите число :");

DateTime d1 = DateTime.Now; // проверка времени затраченое на выполнение задачи
long namA = SumNam((int)sum);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now; // проверка времени затраченое на выполнение задачи
long namB = SumGaus((int)sum);
Console.WriteLine(DateTime.Now - d2);

PrintAnsver(namA, "сумма чисел :");
PrintAnsver(namB, "сумма чисел :");
