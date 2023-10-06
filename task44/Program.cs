// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
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


int[] Fib(int num)
{
    int[] fibArr = new int[num];
    fibArr[0] = 0;
    fibArr[1] = 1;
    for (int i = 2; i <= num - 1; i++)
    {
        fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
    }
    return fibArr;
}

int number = GetUserInput("Введите N >= 2");

if (number < 2)
{
    Console.WriteLine("Некоректный ввод");
    return;
}

int[] resArray = Fib(number);
Console.WriteLine($"Если N = {number} -> {Join(resArray)}");

