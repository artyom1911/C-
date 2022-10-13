// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] myArr = new int [size];
int sum = 0;

for (int i = 0; i < size; i+=1)
{
    myArr [i] = new Random().Next (100, 999);
        if (myArr[i]% 2 == 0)
        {
            sum++;
        }
}



 Console.WriteLine($"Массив из {size} элементов: {string.Join(", ", myArr )} , Четных чисел = {sum}  ");