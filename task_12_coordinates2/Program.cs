// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("введите номер от 1 до 4");
int diapazone = int.Parse(Console.ReadLine());

if( diapazone == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if (diapazone == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if (diapazone == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if (diapazone == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else Console.WriteLine("вы ввели некорректное значение");