﻿// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountNum (int number)
{
    int count = 0;
    while(number > 0)
    {
        number /=10;
        count ++;
    }
    return count;
}
int num = Convert.ToInt32(Console.ReadLine());
int count = CountNum(num);
Console.WriteLine($"в числе {num} - {count} цифр");