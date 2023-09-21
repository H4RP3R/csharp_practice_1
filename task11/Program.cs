// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DelMidDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

int randNum = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано новое число {randNum}");
int result = DelMidDigit(randNum);
Console.WriteLine(result);
