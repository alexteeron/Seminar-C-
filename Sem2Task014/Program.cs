// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// int num1 = int.Parse(Console.ReadLine() ?? "0");
// bool tes1 = (num1 % 7 == 0);
// bool tes2 = (num1 % 23 == 0);
// if (tes1 && tes2) // && - логическое"и"
// {                //  || - логическое "или"
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine("не кратно");
// }

int nam1 = int.Parse(Console.ReadLine() ?? "0");
bool test1 = (nam1 % 7 == 0);
bool test2 = (nam1 % 23 == 0);
if (test1 && test2)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");
}