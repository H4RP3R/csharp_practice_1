// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetUserInput()
{
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool IsNumberValid(int number)
{
    if (number >= 100 && number < 1000) return true;
    else if (number > -1000 && number <= -100) return true;
    else return false;
}

int Abs(int number)
{
    return (number < 0) ? -number : number;
}

int SecondDigit(int threeDigitNum)
{
    return threeDigitNum % 100 / 10;
}

int num = GetUserInput();
bool numIsValid = IsNumberValid(num);

if (numIsValid)
{
    int result = SecondDigit(num);
    Console.WriteLine($"{num} -> {Abs(result)}");
}
else
{
    Console.WriteLine("Введенное число не соответствует условию");
}
