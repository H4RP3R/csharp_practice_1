// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


string Join(double[] array, string sep = " ", string wrapLeft = "", string wrapRight = "")
{
    string output = "";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]:F2}{sep}" : $"{array[i]:F2}";
    }

    return $"{wrapLeft}{output}{wrapRight}";
}

double[] CreateRandDoubleArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

double MaxInArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    return max;
}

double MinInArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }

    return min;
}

double NumberDifference(double max, double min)
{
    return max - min;
}

double[] randArr = CreateRandDoubleArray(5, 0, 100);
double maxVal = MaxInArray(randArr);
double minVal = MinInArray(randArr);
double diff = NumberDifference(maxVal, minVal);

Console.Write(Join(randArr, ", ", "[", "]"));
Console.WriteLine($" => {maxVal:F2} - {minVal:F2} = {diff:F2}");

