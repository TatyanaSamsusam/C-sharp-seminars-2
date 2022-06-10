/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8   */

Console.Write("Введите число: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int numB = int.Parse(Console.ReadLine());

void Pow (int a, int b, int count, int result)
{
    if (count == b) 
    {
        Console.WriteLine(result);
        return;
    }

    result = result*a;
    count++;
    Pow(a, b, count, result);
}
 
Pow(numA, numB, 0, 1);
