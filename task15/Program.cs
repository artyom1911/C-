// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write ("Введите число от 1 до 7 ");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 5 && day >= 1) 
    Console.WriteLine("Будний день");
else if (day <= 7 && day >= 6) 
    Console.WriteLine("Выходной день");
else
     Console.WriteLine("Некорректный ввод данных");
