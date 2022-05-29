/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.WriteLine("введите число в десятичной системе: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());

void DecToOther (int n, int baseN)
{
    if (n == 0) return;
    DecToOther ( n / baseN, baseN);
    Console.Write(n % baseN);
}

DecToOther(num, baseNum);