// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] Array3D(int x = 4, int y = 4, int z = 4)
{
    return new int[x, y, z];
}

void Fill3DArray(int[,,] array)
{
    List<int> numbers = Enumerable.Range(10, 90).ToList();
    Random rand = new();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int index = rand.Next(0, numbers.Count);
                array[i, j, k] = numbers[index];
                numbers.RemoveAt(index);
            }
        }
    }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"({i},{j},{k}){array[i, j, k],4}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

bool IsInputValid(int x, int y, int z)
{
    return x * y * z <= 90;
}

Console.WriteLine("Ведите размерность 3D массива");
int xVal = GetUserInput("Ведите значение X");
int yVal = GetUserInput("Ведите значение Y");
int zVal = GetUserInput("Ведите значение Z");
bool inputValid = IsInputValid(xVal, yVal, zVal);

if (inputValid)
{
    int[,,] arr = Array3D(xVal, yVal, zVal);
    Fill3DArray(arr);
    Print3DArray(arr);
}
else
{
    Console.WriteLine("Некорректный ввод");
    Console.WriteLine("X * Y * Z должно быть <= 90");
}
