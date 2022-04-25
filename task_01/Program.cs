// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.WriteLine("введите 2 целых числа, и я скажу, является ли второе число квадратом первого: ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a*a == b) 
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}