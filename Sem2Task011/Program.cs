﻿//Задача №11
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int firstNum = num/100; 
// int lastNum = num% 10;
// int newNum = firstNum*10 + lastNum;
// Console.WriteLine(newNum);

System.Random numSintezator = new System.Random();

//char[] digits = numSintezator.Next(100, 1000).ToString().ToCharArray();
// Console.WriteLine(digits);
// char[] res = {digits[0], digits[2]};
// Console.WriteLine(res);

System.Random newNum = new System.Random();
int nam3 = newNum.Next(100,1000);
Console.WriteLine(nam3);
int a = nam3/100;
int b = nam3%10;
int combo = a*10+b;
Console.WriteLine(combo);

char[] digits = numSintezator.Next(100, 1000).ToString().ToCharArray();
Console.WriteLine(digits);
char[] res = {digits[0], digits[2]};
Console.WriteLine(res);

