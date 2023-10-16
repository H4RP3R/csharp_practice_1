// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int SumDigitsInNumber(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SumDigitsInNumber(number / 10);
}

int num = GetUserInput("Enter a number");
Console.WriteLine($"{num} -> {SumDigitsInNumber(num)}");
