// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// d=√((x2 – x1)² + (y2 – y1)²)
double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

int x1 = GetUserInput("Координаты первой точки\nВведите координату X");
int y1 = GetUserInput("Введите координату Y");
Console.WriteLine("------------------------");
int x2 = GetUserInput("Координаты второй точки\nВведите координату X");
int y2 = GetUserInput("Введите координату Y");

double distance = Distance(x1, y1, x2, y2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

