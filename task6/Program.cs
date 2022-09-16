//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write ("Введите число 1 ");
int number1 = int.Parse(Console.ReadLine());


if(number1 % 2 == 0)
    Console.WriteLine ($"{number1} является четным");
else
    Console.WriteLine ($"{number1} является нечетным");

