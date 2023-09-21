// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetUserInput()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool IsNumberValid(int number)
{
    return (number < -99 || number > 99) ? true : false;
}

int ThirdDigit(int number)
{
    while (number >= 1000 || number <= -1000)
    {
        number /= 10;
    }
    return Math.Abs(number % 10);
}

int num = GetUserInput();
bool numValid = IsNumberValid(num);

if (numValid)
{
    int res = ThirdDigit(num);
    Console.WriteLine($"{num} -> {res}");
}
else
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
