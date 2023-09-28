// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random rand = new();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rand.Next(100);
    }
    Console.Write(string.Join(", ", array));
    Console.Write(" -> ");
    return array;
}

void PrintArray(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}]";
    }
    Console.WriteLine(output);
}

int[] arr = RandomArray(8);
PrintArray(arr);
