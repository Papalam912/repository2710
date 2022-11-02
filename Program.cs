// Console.WriteLine("Hello, World!");

Console.Clear();

// семинар 134

// // 1. Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// // int sqrt = number * number;
// // number *= number;
// int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine("число в квадрате: " + sqrt1);

// 2. Напишите программу которая на вход принимает трехзначное число и на выходе показывает последнуюю цифру этого числа

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 999)
{
    Console.Write("Последняя цифра: " + Math.Abs(num) % 10);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}
