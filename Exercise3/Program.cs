// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)Console.WriteLine($"> {numberFirst}");
else if (number > numberSecond)Console.WriteLine($"> {number}");
else  Console.WriteLine($"> {numberSecond}");

