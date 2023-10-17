// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());

}

bool IsNotNegativeNum(int number)
{
    return number >= 0;
}

int Ackermann1(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann1(m - 1, 1);
    else return Ackermann1(m - 1, Ackermann1(m, n - 1));
}

int Ackermann2(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = Ackermann2(m, n - 1);
        m -= 1;
    }
    return n + 1;
}

int mValue = GetUserInput("Enter a value for 'm'");
int nValue = GetUserInput("Enter a value for 'n'");

bool mNotNegative = IsNotNegativeNum(mValue);
bool nNotNegative = IsNotNegativeNum(nValue);

if (mNotNegative && nNotNegative)
{
    Console.WriteLine($"[Ackermann 1] m = {mValue}, n = {nValue} -> A(m,n) = {Ackermann1(mValue, nValue)}");
    Console.WriteLine($"[Ackermann 2] m = {mValue}, n = {nValue} -> A(m,n) = {Ackermann2(mValue, nValue)}");
}
else
{
    Console.WriteLine("Both numbers must not be negative");
}