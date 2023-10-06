// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x +
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    return new double[2] { x, y };
}

Console.WriteLine("Программа находит точку пересечения двух прямых, заданных уравнениями");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");

int B1 = GetUserInput("Введите b1");
int K1 = GetUserInput("Введите k1");
int B2 = GetUserInput("Введите b2");
int K2 = GetUserInput("Введите k2");

if (K1 == K2)
{
    Console.WriteLine("Нет точки пересечения");
    return;
}

double[] coords = IntersectionPoint(B1, K1, B2, K2);
Console.WriteLine($"b1 = {B1}, k1 = {K1}, b2 = {B2}, k2 = {K2} -> ({coords[0]:F3}, {coords[1]:F3})");
