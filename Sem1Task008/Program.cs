//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
String? InLine = Console.ReadLine();

if (InLine != null)
{
    int x = 0;
    int count = 1;
    int N = int.Parse(InLine);
    while (count <= N)
    {
        if (count % 2 == 0) 
        {
            x = x + 2; 
            Console.Write(x + ", ");
        }
        count++;
    }
}