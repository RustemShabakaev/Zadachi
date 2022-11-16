// 1.Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// 2. и на выходе показывает вторую цифру этого числа. 
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите Трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if ((Math.Abs(number) < 99) || (Math.Abs(number) > 999))
{
    Console.WriteLine("Число не трехзначное, введите другое число");
}
else
{
    int num = number % 100;
    int result = num / 10;
    Console.WriteLine($"{number} -> {result}");
}