// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
if (numberFirst % 2 == 0)
{
Console.WriteLine($"четное {numberFirst}");
}
else
{
    Console.WriteLine($"нечетное {numberFirst}");
}