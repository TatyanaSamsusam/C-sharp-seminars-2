/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

Console.Write("введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] nums = new int[size];
int positive = 0;
int negative = 0;

var NewRnd = new Random();
for (int i = 0; i < size; i++)
{
    nums[i] = NewRnd.Next(-9,10);
    Console.Write(nums[i] + " ");
}

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0) positive = positive + nums[i];
    else negative = negative + nums[i];
}
Console.WriteLine();
Console.WriteLine($"в массиве сумма положительных чисел равна {positive}, сумма отрицательных равна {negative}");