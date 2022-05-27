/*Задача 31: Задайте массив c клавиатуры. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

// Console.Write("введите размер массива: ");
// int size = int.Parse(Console.ReadLine());

Console.Write("введите элементы массива через пробел: ");
int[] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.WriteLine(string.Join(' ', numsArr));

//int[] nums = new int[size];
int positive = 0;
int negative = 0;

/*var NewRnd = new Random();
for (int i = 0; i < size; i++)
{
    nums[i] = NewRnd.Next(-9,10);
    Console.Write(nums[i] + " ");
}*/

for (int i = 0; i < numsArr.Length; i++)
{
    if (numsArr[i] > 0) positive = positive + numsArr[i];
    else negative = negative + numsArr[i];
}
Console.WriteLine();
Console.WriteLine($"в массиве сумма положительных чисел равна {positive}, сумма отрицательных равна {negative}");