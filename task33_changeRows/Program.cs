// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}


void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Replace (int[,] array)
{
    int n = array.GetLength(0) - 1;                       // в n в n помещается значение колличества строк в массиве -1. из-за того, что индекс с 0, там будет значение последней строки. 
    for (int i = 0; i < array.GetLength(1); i++)          
    {
        int temp = array[0,i];                            // загнали в temp значение первого элемента первой строки
        array[0,i] = array[n,i];                          // загнали в первый элемент первой строки значение первого элемента последней строки
        array[n,i] = temp;                                // загнали в первый элемент последней строки значение, хранящееся в temp
    }
    return array;
}

int [,] arr = GetArray(4,5);
PrintArray(arr);
Console.WriteLine();
int [,] temporArr = Replace(arr);
PrintArray(temporArr);