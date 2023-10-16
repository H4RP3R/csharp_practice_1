// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());

}

int NaturalNumsSumInRange(int m, int n)
{
    if (m < n) return m + NaturalNumsSumInRange(m + 1, n);
    else if (m > n) return m + NaturalNumsSumInRange(m - 1, n);
    else return n;
}

bool IsNaturalNumber(int number)
{
    return number > 0;
}

int mValue = GetUserInput("Enter a value for M");
int nValue = GetUserInput("Enter a value for N");

bool mNatural = IsNaturalNumber(mValue);
bool nNatural = IsNaturalNumber(nValue);

if (mNatural && nNatural)
{
    Console.WriteLine($"M = {mValue}; N = {nValue} -> {NaturalNumsSumInRange(mValue, nValue)}");
}
else
{
    Console.WriteLine("Both numbers must be greater than zero.");
}