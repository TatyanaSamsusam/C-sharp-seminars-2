// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 

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

Console.WriteLine("введите кол-во строк");
int userRow = int.Parse(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов");
int userCol = int.Parse(Console.ReadLine());

int [,] arr = GetArray(userRow, userCol);
PrintArray(arr);

int [,] ModifyArr (int [,] array)
{
    int[,] flipArr = new int [userRow, userCol];
    for (int i = 0; i < flipArr.GetLength(0); i++)
    {
        for (int j = 0; j < flipArr.GetLength(1); j++)
        {
            flipArr[i,j] = arr[j,i];
        }
    }
    return flipArr;
}
Console.WriteLine();
int[,] flipArray = ModifyArr(arr);
PrintArray(flipArray);
