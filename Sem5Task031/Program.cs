// //Задача № 31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]
// найдите сумму положительных и отрицательных элементов массива
Console.Clear();
int globPosSum = 0;
int globNegSum = 0;

int[] Gen1DArrey(int len, int but, int top) //метод заполненния 
{
    if (but > top)
    {
        int buf = but;
        but = top;
        top = buf;
    }
    Random rnd = new Random();                                       //случайными числами
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = rnd.Next(but, top + 1);
    }
    return res;
}
void Print1DArrey(int[] arr) //вывод данных
{                            //создаем тело в которое положим данные
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
void NegPosSumV1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            globPosSum += arr[i];
        }
        else
        {
            globNegSum += arr[i];
        }
    }
}

int[] NegPosSumV2(int[] arr)
{
    int positivSum = 0;
    int negativSum = 0;
    int[] outArrey = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negativSum += arr[i];
        }
    }
    outArrey[0] = positivSum;
    outArrey[1] = negativSum;
    return outArrey;
}
(int positiv,int negativ) NegPosSumV3(int[] arr)
{
    int positivSum = 0;
    int negativSum = 0;
    int[] outArrey = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negativSum += arr[i];
        }
    }
    
    return (positivSum,negativSum);
}
int[] testArr = Gen1DArrey(12, -9, 9);
Print1DArrey(testArr);
NegPosSumV1(testArr);
int[] res = NegPosSumV2(testArr);
(int positiv, int negativ) sumV3 = NegPosSumV3(testArr);
Console.WriteLine("сумма положительных чисел массива(v1) : " + globPosSum);
Console.WriteLine("сумма отрицательных чисел массива(v1) : " + globNegSum);

Console.WriteLine("сумма положительных чисел массива(v2) : " + res[0]);
Console.WriteLine("сумма отрицательных чисел массива(v2) : " + res[1]);

Console.WriteLine("сумма положительных чисел массива(v3) : " + sumV3.positiv);
Console.WriteLine("сумма отрицательных чисел массива(v3) : " + sumV3.negativ);
