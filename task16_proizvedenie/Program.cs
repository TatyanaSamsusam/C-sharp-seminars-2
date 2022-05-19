/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

Console.WriteLine("введи число, и я покажу произведение от 1 до твоего числа");
int num = int.Parse(Console.ReadLine());

int FindMultiple(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}

int result = FindMultiple(num);
Console.WriteLine($"произведение чисел от 1 до {num} равно {result}");

