// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("введите размер массива");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];
var NewRnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = NewRnd.Next(5,9);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int [] array2 = new int[size];
for (int i = 0; i < size; i++)
{
    array2[i] = array[i];
    Console.Write(array2[i] + " ");
}
Console.WriteLine();