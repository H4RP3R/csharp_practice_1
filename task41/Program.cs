// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

string Join(int[] array, string sep = " ", string wrapLeft = "", string wrapRight = "")
{
    string output = "";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}{sep}" : $"{array[i]}";
    }

    return $"{wrapLeft}{output}{wrapRight}";
}


int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetArrayFromInput()
{
    int size = GetUserInput("Задайте размер массива");
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetUserInput($"Введите число №{i + 1}");
    }

    return array;
}

int CountPositiveNumbers(int[] numbers)
{
    int result = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) result++;
    }

    return result;
}

int[] arr = GetArrayFromInput();
int positiveNums = CountPositiveNumbers(arr);
Console.WriteLine($"{Join(arr, ", ")} -> {positiveNums}");
