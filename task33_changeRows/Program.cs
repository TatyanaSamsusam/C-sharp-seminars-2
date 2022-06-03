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
    int n = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)          //цикл проходит только по столбцам
    {
        int temp = array[0,i];                            // загнали в temp значение первой строки
        array[0,i] = array[n,i];                          // загнали в первую строку значение последней строки
        array[n,i] = temp;                                // загнали в последнюю строку значение 1 строки, хранящееся в temp
    }
    return array;
}

int [,] arr = GetArray(3,3);
PrintArray(arr);
Console.WriteLine();
int [,] temporArr = Replace(arr);
PrintArray(temporArr);