// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("введите размер массива:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("какое число ищем? ");
int find = int.Parse(Console.ReadLine());
string result = "нет";

int[] array = new int[size];
var NewRnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = NewRnd.Next(1,10);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < size; i++)
{
    if (array[i] == find) result = "да";
}
Console.WriteLine(result);
