// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N: 
// M=1, N=5:  1,2,3,4,5
// M=4, N=8:  4,5,6,7,8

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

PrintNatNum(m, n);
Console.ReadKey();

void PrintNatNum(int n, int m)
{
    if (n == m)
    {
        Console.Write($"{n} ");
        return;
    }
    if (m == n)
    {
        PrintNatNum(n-1,m);
        Console.Write($"{n} ");
        return;
    }   
    else
    {
        PrintNatNum(n+1,m);
        Console.Write($"{n} ");
        return;
    }
}