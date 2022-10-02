// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int check = number1 % 100;
int check2 = number1 / 1000;

if (check/10 == check2 % 10 && check % 10 == check2 / 10)
{
    Console.WriteLine("Число является палиндромом");
}

else
{
    Console.WriteLine("Число не является палиндромом");
}