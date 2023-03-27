//задача №9
//Напишите число которое выводит случайное число из отреска [10, 99]
//И показывает наибольшую цифру числа

System.Random numSintezator = new System.Random();

//Вариант 1
int rndNum = numSintezator.Next(10,100);
Console.WriteLine(rndNum);
//short firstNum = (short)(rndNum/10);
//short secondNam = (short)(rndNum % 10);


int firstNum = rndNum/10;
int secondNam = rndNum % 10;


if (firstNum > secondNam)
{
    Console.WriteLine("Первое число больше" + firstNum);
}
else
{
    Console.WriteLine(secondNam);
}

//вариант2
