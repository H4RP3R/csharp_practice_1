// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 0) number *= -1;
if (number <= 999 && number >= 100)
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра вашего числа {lastDigit}");
}
else
{
    Console.WriteLine("Неправильный ввод");
}

