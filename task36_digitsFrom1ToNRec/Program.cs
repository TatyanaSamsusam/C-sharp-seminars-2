// напиши программу, которая принимает на вход одно число (N), а на выходе показывает все целые числа в промежутке от 1 до N

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

NaturalNumber(n);
Console.ReadKey();

void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num-1);
    Console.Write(num + " ");
}
