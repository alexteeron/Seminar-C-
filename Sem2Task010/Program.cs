// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите число");
int numN = int.Parse(Console.ReadLine() ?? "0");
//создаем массив, переводим в строки и делим по цыфрам
char[] nam1 = numN.ToString().ToCharArray();
Console.WriteLine(nam1);

// вытаскиваем "2" цыфру из массива
char[] nam2 = { nam1[1] };
Console.WriteLine(nam2);