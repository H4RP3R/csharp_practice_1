// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа выводит четные числа в диапазоне от 1 до N");

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    for (int i = 2; i <= number; i += 2)
    {
        Console.Write(i < number - 1 ? $"{i}, " : $"{i}\n");
    }
}
else
{
    Console.WriteLine($"Число {number} не является натуральным");
}