Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.Readline());
Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.Readline());

if (numberFirst == numberSecond * numberSecond)
{
	Console.WriteLine($"{numberFirst} является квадратом {numberSecond}");
}
else
{
	Console.WriteLine($"{numberFirst} не квадрат {numberSecond}");
}