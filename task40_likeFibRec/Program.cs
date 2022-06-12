/* Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 */

Console.Write("введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.Write("введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("введите число B: ");
int b = int.Parse(Console.ReadLine());


void FibRec (int a, int b, int count)
{
    int sum = 0;
    if (count == 0) return;
  
    sum = a + b;
    a = b;
    b = sum;
    Console.Write($"{sum} ");
    FibRec(a, b, count-1);
}

Console.Write(a + " " + b + " ");
FibRec(a, b, N-2);