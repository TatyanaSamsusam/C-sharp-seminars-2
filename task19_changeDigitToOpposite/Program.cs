// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("введите размер массива:");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];
var NewRnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = NewRnd.Next(-9,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("а вот массив, умноженный на -1: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + " ");
}

Console.WriteLine();
