// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrarRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void SignInversion(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        // numbers[i] *= -1;
        numbers[i] = -numbers[i];
    }
}

void PrintOut(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    // arr[^1] последний эллемент массива
    Console.Write($"{arr[^1]}]");
}

int[] randArr = CreateArrarRndInt(5, -10, 11);
PrintOut(randArr);
SignInversion(randArr);
Console.Write(" -> ");
PrintOut(randArr);
Console.WriteLine();

