// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int quarter = Convert.ToInt32(Console.ReadLine());
    return quarter;
}

Dictionary<string, int> CoordinateRange(int quarter)
{
    switch (quarter)
    {
        case 1:
            return new Dictionary<string, int>
            {
                {"xMin", 1},
                {"xMax", int.MaxValue},
                {"yMin", 1},
                {"yMax", int.MaxValue}
            };
        case 2:
            return new Dictionary<string, int>
            {
                {"xMin", -1},
                {"xMax", int.MinValue},
                {"yMin", 1},
                {"yMax", int.MaxValue}
            };
        case 3:
            return new Dictionary<string, int>
            {
                {"xMin", -1},
                {"xMax", int.MinValue},
                {"yMin", -1},
                {"yMax", int.MinValue}
            };
        case 4:
            return new Dictionary<string, int>
            {
                {"xMin", 1},
                {"xMax", int.MaxValue},
                {"yMin", -1},
                {"yMax", int.MinValue}
            };
        default:
            return new Dictionary<string, int> { };
    }
}

int quarter = GetUserInput("Введите номер четверти");
Dictionary<string, int> range = CoordinateRange(quarter);

if (range.Count > 0)
{
    Console.WriteLine($"X от {range["xMin"]} до {range["xMax"]}, Y от {range["yMin"]} до {range["yMax"]}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}