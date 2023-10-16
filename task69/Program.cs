// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int NumPow(int number, int power)
{
    if (power == 0) return 1;
    else return number * NumPow(number, power - 1);
}

int aVal = GetUserInput("Enter a number");
int bVal = GetUserInput("Enter a power of the number");

if (bVal < 1)
{
    Console.WriteLine("The power of the number must be greater than zero.");
    return;
}

Console.WriteLine($"A = {aVal}; B = {bVal} -> {NumPow(aVal, bVal)}");
