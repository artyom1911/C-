﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write ("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Максимальное число {number1} ");
}
else{
    Console.WriteLine($"Максимальное число {number2} ");
}


