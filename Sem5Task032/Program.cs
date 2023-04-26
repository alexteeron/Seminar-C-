// задача № 32
// напишите программу замены элементов массива,
// положительные на отрицательные и наоборот
// инвертирование массива

Console.Clear();


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
void InverMass(int[] arr)//метод инверсинности массива
                         //метод выдает данные путем ссылочного типа 
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }

}
int[] nam = Gen1DArrey(12, -9, 9);
Print1DArrey(nam);
InverMass(nam);
Print1DArrey(nam);//ссылочным типом, через метод меняет сам массив 
InverMass(nam);
Print1DArrey(nam);              