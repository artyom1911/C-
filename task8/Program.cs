/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write ("Введите число 1 ");
int number1 = int.Parse(Console.ReadLine());
int even_number = 2;

while (number1 >= even_number )
{
    Console.WriteLine ($"{even_number}");
    even_number = even_number + 2;
}