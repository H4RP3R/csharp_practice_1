// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int OddNumPositionSum(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum += numbers[i];
    }

    return sum;
}

int[] randArr = CreateRandIntArray(4, -10, 10);
int result = OddNumPositionSum(randArr);
Console.Write(Join(randArr, ", ", "[", "]"));
Console.WriteLine($" -> {result}");

