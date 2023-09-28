// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PowNum(int number, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}


int firstNum = GetUserInput("Введите число");
int secondNum = GetUserInput("Введите степень");
int res = PowNum(firstNum, secondNum);
Console.WriteLine($"{firstNum}, {secondNum} -> {res}");
