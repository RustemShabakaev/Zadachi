// 1.Задача 15: Напишите программу, которая принимает на вход цифру,
// 2.обозначающую день недели, и
// 3.проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
    if (day == 6 || day == 7)
    {
        Console.WriteLine($"{day} -> Да, выходной");
    }
    else 
    {
        Console.WriteLine($"{day} -> Рабочий день");
    }
    else 
    {
        Console.WriteLine($"{day} -> Введите другое число");
    }