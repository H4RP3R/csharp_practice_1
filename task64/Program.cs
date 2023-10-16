// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsNaturalNumber(int number)
{
    return number > 1;
}

string NaturalNumbers(int n)
{
    if (n == 1) return "1";
    else return $"{n}, " + NaturalNumbers(n - 1);
}

int N = GetUserInput("Enter a natural number");
bool naturalNumber = IsNaturalNumber(N);

if (naturalNumber) Console.WriteLine($"N = {N} -> \"{NaturalNumbers(N)}\"");
else Console.WriteLine("Invalid input");
