//задача №9
//Напишите число которое выводит случайное число из отреска [10, 99]
//И показывает наибольшую цифру числа

System.Random numSintezator = new System.Random();

//Вариант 1
int rndNum = numSintezator.Next(10, 100);
Console.WriteLine(rndNum);
//short firstNum = (short)(rndNum/10);
//short secondNam = (short)(rndNum % 10);


int firstNum = rndNum / 10;
int secondNam = rndNum % 10;


if (firstNum > secondNam)
{
    Console.WriteLine("Первое число больше" + firstNum);
}
else
{
    Console.WriteLine(secondNam);
}

//вариант2 Массив
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);

if (digits[0] == digits[1]) Console.WriteLine("ровны");

if (digits[0] > digits[1])
{
    Console.WriteLine("первое число больше " + digits[0]);
}
else
{
    Console.WriteLine("Второе число больше " + digits[1]);
}

int res = (firstNum > secondNam) ? firstNum : secondNam;
Console.WriteLine(res);
//Вариант 3