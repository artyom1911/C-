// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Определите колличество значений ");
int size = Convert.ToInt32(Console.ReadLine());
int [] myArr = new int [size];
int diff = 0;

for (int i = 0; i < size; i+=1 )
{
    myArr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < size; i+=1 )
{
    if (myArr[i] > 0 )
    {
        diff+=1;
    }
}

Console.WriteLine($"{string.Join(", ", myArr )}  Значений больше 0 = {diff}");