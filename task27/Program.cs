// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumDigits(int num)
{
    int[] digits = new int[] { };
    int result = 0;

    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}


int num = GetUserInput("Введите число");
int res = SumDigits(num);

Console.WriteLine($"{num} -> {res}");

