// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.


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

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }

    return copy;
}

int[] randArr = CreateRandIntArray(5, -10, 10);
int[] copiedArr = CopyArray(randArr);
Console.WriteLine($"{Join(randArr, ", ", "[", "]")} -> {Join(copiedArr, ", ", "[", "]")}");
Console.WriteLine(randArr.Equals(copiedArr)); // Ссылаются ли массивы на один и тот же адресс в памяти
Console.WriteLine(randArr.SequenceEqual(copiedArr)); // Идентично ли содержимое массивов

