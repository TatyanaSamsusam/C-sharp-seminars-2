/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.WriteLine("введите число в десятичной системе: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());

int d10 = 1;
int result = 0;

while(num !=0)
{
    result = result + num % baseNum * d10;
    num = num / baseNum;
    d10 = d10 * 10;
}

Console.WriteLine(result);