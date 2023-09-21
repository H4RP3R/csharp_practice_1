// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System.Globalization;

int GetUserInput()
{
    Console.Write($"Введите номер дня недели: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsValidDayNum(int num)
{
    return (num >= 1 && num <= 7);
}

string IsItWeekend(int num)
{
    return (num == 6 || num == 7) ? "да" : "нет";
}

int dayNum = GetUserInput();
bool validDayNum = IsValidDayNum(dayNum);

if (validDayNum)
{
    Console.WriteLine($"{dayNum} -> {IsItWeekend(dayNum)}");
}
else
{
    Console.WriteLine("Неправильный ввод");
}
