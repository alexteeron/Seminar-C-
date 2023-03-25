//Программа для выисления максимального и минимального значения из 2х чисел
//задание: ввести числа 5,7; 2,10; -9,-3
Console.WriteLine("Введите число");
//Сконвертируем значение консоли
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;
if (a > b) max =a;
           min =b;
if(b>a) max = b; 
        min = a;
Console.WriteLine(min); //Получаем минимальное значение
Console.WriteLine(max); //получаем максимальное значение