// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

// Console.WriteLine("Введите номер дня недели");
// int dey = int.Parse(Console.ReadLine()??"0");

// if(dey<1||dey>7) 
// {
//     Console.WriteLine("не день недели");
// }
// else
// {
//     if(dey>5)
//     {
//         Console.WriteLine("выходной");
//     }
//     else
//     {
//         Console.WriteLine("буднии");
//     }
// }

Console.Clear();
int InputNam(string messege)//Метод ввода данных
{
    Console.Write(messege);
    int resault = Convert.ToInt32(Console.ReadLine());
    return resault;
}

bool Weekend(int weekDay) //Метод сравнения "правда или лож"
{                         //нахождения выходного  
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool NotDay(int weekDay) //Метод сравнения "правда или лож"
{                        //проверка правельности ввода
    if (weekDay > 1 && weekDay <= 7)
    {
        return true;
    }
    Console.WriteLine("такого дня нет");
    return false;
}


int weekDay = InputNam("введите число >");
if (NotDay(weekDay))
{
    if (Weekend(weekDay))
    {
        Console.WriteLine("ура выходной");
    }
    else
    {
        Console.WriteLine("надо работать");
    }
}

// задание со звездочкой*
Dictionary<int,string> deysOfWeek =new Dictionary<int,string>(); //Работа со славарем, создаем словарь Dictionary
deysOfWeek.Add(1, "будний день");                                //заполнили словарь   
deysOfWeek.Add(2, "будний день");
deysOfWeek.Add(3, "будний день");
deysOfWeek.Add(4, "будний день");
deysOfWeek.Add(5, "будний день");
deysOfWeek.Add(6, "выходной день");
deysOfWeek.Add(7, "выходной день");

Console.Write("введите день недели > ");
int day = int.Parse(Console.ReadLine()??"0");

if (deysOfWeek.ContainsKey(day))     // проверка и вывод результата
{
    Console.WriteLine(deysOfWeek[day]);
}
else
{
    Console.WriteLine("не день недели");
}