// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве
// [345, 897, 568, 234] -> 2

int[] CreateRandIntArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

string Join(int[] array, string sep = " ", string wrapLeft = "", string wrapRight = "")
{
    string output = "";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}{sep}" : $"{array[i]}";
    }

    return $"{wrapLeft}{output}{wrapRight}";
}

int CountEvenNums(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0) count++;
    }

    return count;
}

int[] randArr = CreateRandIntArray(4, 100, 999);
int result = CountEvenNums(randArr);

Console.Write(Join(randArr, sep: ", ", wrapLeft: "[", wrapRight: "]"));
Console.WriteLine($" -> {result}");
