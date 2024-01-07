// 1.напишите программу, которая принимает на вход число
 // и проверяет, кратно ли оно одновременно 7 и 23.

 using System;

 class Program

 {
    static void Main ()
    {
        Console.Write("введите число a: ");
        int a = Console.Tolnt32(Console.ReadLine());

        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }  
 }