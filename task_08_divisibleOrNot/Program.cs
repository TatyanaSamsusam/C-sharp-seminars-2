// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if (numberA % numberB == 0) Console.WriteLine("числа кратны");
else Console.WriteLine("число 1 не кратно числу 2, остаток от деления равен " + numberA % numberB);