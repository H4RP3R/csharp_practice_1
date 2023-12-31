﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string DecimalToBinary(int number, int baseNum)
{
    string result = String.Empty;

    while (number > 0)
    {
        result = number % baseNum + result;
        number /= baseNum;
    }
    return $"'0b{result}'";
}

int DecimalToBinaryInt(int number, int baseNum)
{
    int result = 0;
    int mult = 1;

    while (number > 0)
    {
        result = number % baseNum * mult + result;
        mult *= 10;
        number /= baseNum;
    }
    return result;
}

int num = GetUserInput("Enter a number");
int baeNumber = GetUserInput("Enter base number");

string binNum = DecimalToBinary(num, baeNumber);
Console.WriteLine($"{num} -> {binNum}");
int binNumInt = DecimalToBinaryInt(num, baeNumber);
Console.WriteLine($"{num} -> {binNumInt}");
