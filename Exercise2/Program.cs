// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond)
{
	Console.WriteLine($"{numberFirst} является больше чем {numberSecond}");
}
else
{
	Console.WriteLine($"{numberFirst} является меньше чем {numberSecond}");
}
