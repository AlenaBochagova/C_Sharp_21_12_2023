// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.

Console.Write("Enter a number 1: ");
int b1 = Convert.Tolnt32 (Console.ReadLine()!);
Console.Write("Enter a number 2: ");
int b2 = Convert.Tolnt32(Console.ReadLine()!);

if (b2 *b2 == b1)
    Console.WriteLine ("Yes");
else
    Console.WriteLine ("No");
