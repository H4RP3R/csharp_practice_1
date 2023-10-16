// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool IsNaturalNumber(int number)
{
    if (number < 1) return false;
    else return true;
}

string NaturalNumbers(int n)
{
    if (n == 1) return "1";
    else return NaturalNumbers(n - 1) + $", {n}";
}

int N = GetUserInput("Enter a natural number");
bool naturalNumber = IsNaturalNumber(N);

if (naturalNumber)
{
    Console.WriteLine($"N = {N} -> \"{NaturalNumbers(N)}\"");
}
else
{
    Console.WriteLine("Invalid input");
}