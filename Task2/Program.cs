// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num ==7)
    Console.WriteLine("Выходной день!");
else if (num <= 5)
    Console.WriteLine("Будний день!");
else if (num < 1 || num >7);
    Console.WriteLine("В неделе всего 7 дней!"); 