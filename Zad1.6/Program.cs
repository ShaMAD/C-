﻿int a = 0;
Console.Write($"Введите число: "); int.TryParse(Console.ReadLine()!, out a);

if (a % 2 == 0)
    Console.WriteLine($"Число {a} четное");
else
    Console.WriteLine($"Число {a} нечетное");