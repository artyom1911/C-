// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int number3 = 0;
if (number > 10000 && number < 99999)
{
   number3 = number / 100 ;
   Console.WriteLine($"{number3} ");
   number3 = number3 - number3 / 10 * 10 ;
   Console.WriteLine($"Третье число от {number} будет {number3} "); 
}
 if (number > 1000 && number < 9999)
{
   number3 = number / 10 ;
   Console.WriteLine($"{number3} ");
   number3 = number3 - number3 / 10 * 10 ;
   Console.WriteLine($"Третье число от {number} будет {number3} "); 
}
if (number > 100 && number < 999)
{
   number3 = number ;
   Console.WriteLine($"{number3} ");
   number3 = number3 - number3 / 10 * 10 ;
   Console.WriteLine($"Третье число от {number} будет {number3} "); 
}
if (number > 10 && number < 99)
{
   Console.WriteLine("Третьей цифры нет");
    
}
if (number > 1 && number < 9)
{
   Console.WriteLine("Третьей цифры нет");
    
}


