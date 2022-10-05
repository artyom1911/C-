// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number1 = Convert.ToInt32(Console.ReadLine());
int dig = 0;
int sum = 0;

while (number1 > 0)
{
    dig = number1 % 10;
    sum = sum + dig;
    number1 = number1 / 10;
}

Console.WriteLine(sum);