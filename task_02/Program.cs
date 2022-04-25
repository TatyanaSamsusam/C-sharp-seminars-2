// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("введите число от 1 до 7, и я напишу, с каким днем недели оно совпадает");
string weekday = Console.ReadLine();


if(weekday == "1")
{
    Console.WriteLine("понедельник");
}
else if(weekday == "2")
{
    Console.WriteLine("вторник");
}
else if(weekday == "3")
{
    Console.WriteLine("среда");
}
else if(weekday == "4")
{
    Console.WriteLine("четверг");
}
else if(weekday == "5")
{
    Console.WriteLine("пятница");
}
else if(weekday == "6")
{
    Console.WriteLine("суббота");
}
else if(weekday == "7")
{
    Console.WriteLine("воскресенье");
}

else Console.WriteLine("wrong number");