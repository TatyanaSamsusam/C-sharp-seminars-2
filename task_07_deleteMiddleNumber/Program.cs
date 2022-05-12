// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine($"random number is {number}");

int lastDigitMethod (int number)
{
    int firstDigit = number % 10;
    int lastDigit = number /100 * 10 + firstDigit;
    return lastDigit;
}

int digitMethod = lastDigitMethod (number);


Console.WriteLine(digitMethod);
