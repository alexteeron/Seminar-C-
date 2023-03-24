// Считываем данные с консоли
String? inLine = Console.ReadLine();

// Проверяем чтоб данные не были пустыми
if (inLine != null)
{
    //Парсим введеное число
    int inNumber = int.Parse(inLine);
    // другой вариант возведение в квадрат
    int OutStrPow = (int)Math.Pow(inNumber, 2);

    // Находим квадрат числа
    int outNamber = inNumber * inNumber;

    // Ввыводим данные в консоль
    Console.WriteLine(outNamber);
    Console.WriteLine(OutStrPow);
}