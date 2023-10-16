// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

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


string NaturalNumbersInRange(int m, int n)
{
    if (m < n) return $"{m}, " + NaturalNumbersInRange(m + 1, n);
    else if (m > n) return $"{m}, " + NaturalNumbersInRange(m - 1, n);
    else return m.ToString();
}

int mValue = GetUserInput("Enter value for M");
int nValue = GetUserInput("Enter value for N");
bool mNaturalNum = IsNaturalNumber(mValue);
bool nNaturalNum = IsNaturalNumber(nValue);

if (mNaturalNum && nNaturalNum)
{
    Console.WriteLine($"M = {mValue}; N = {nValue} -> \"{NaturalNumbersInRange(mValue, nValue)}\"");
}
else
{
    Console.WriteLine("Invalid input");
}
