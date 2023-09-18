// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.Write("Enter day number: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
if (1 <= dayNum && dayNum <= 7)
{
    Console.WriteLine($"day {dayNum} is {days[dayNum - 1]}");
}
else
{
    Console.WriteLine("Wrong number");
}