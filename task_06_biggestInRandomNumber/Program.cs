// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(1,100);
Console.WriteLine($"random number is {number}");
int firstDigit = number / 10;
Console.WriteLine(firstDigit);
int secondDigit = number % 10;
Console.WriteLine(secondDigit);

Console.WriteLine(firstDigit > secondDigit ? $"max digit is {firstDigit}" : $"max digit is {secondDigit}");
