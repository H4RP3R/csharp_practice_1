// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    return (firstDigit > secondDigit) ? firstDigit : secondDigit;
}

int randNum = new Random().Next(1, 100);
Console.WriteLine($"Сгенерировано рандомное число {randNum}");

int maxDigit = MaxDigit(randNum);
Console.WriteLine($"Максимальная цифра {maxDigit}");
