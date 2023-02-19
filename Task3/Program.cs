// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число"!);
int num = int.Parse(Console.ReadLine());

num = num / 100;
if (num > 100)
{
    Console.WriteLine($"Третья цифра числа:{num}" );
}
else
{
    Console.WriteLine("Третьей цифры нет!"); 
}