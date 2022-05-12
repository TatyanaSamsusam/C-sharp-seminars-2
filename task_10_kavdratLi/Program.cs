// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if (numberA * numberA == numberB) Console.WriteLine("yes");
else if (numberB * numberB == numberA) Console.WriteLine("yes");
else Console.WriteLine("no");