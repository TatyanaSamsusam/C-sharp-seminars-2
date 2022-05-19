// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("введи число, и я покажу сумму от 1 до твоего числа");
int num = int.Parse(Console.ReadLine());

int FindSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int result = FindSum(num);
Console.WriteLine($"сумма чисел от 1 до {num} равна {result}");