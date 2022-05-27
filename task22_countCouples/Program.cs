/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] array = new int[6];
var NewRnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = NewRnd.Next(5,9);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int[] newArray = new int[array.Length / 2]; 
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length -1-i];
    Console.Write(newArray[i] + " ");
}

