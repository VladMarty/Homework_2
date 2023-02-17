// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введенного числа числа: {num}");