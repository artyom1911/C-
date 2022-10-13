// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int size = Convert.ToInt32(Console.ReadLine());
int [] myArr = new int [size];
int sum = 0;
for (int i = 0; i < size; i+=1)
{
    myArr[i] = new Random().Next (-9,9);
    
}
for (int j = 0; j < size; j+=2)
{
    sum += myArr[j];
}
Console.WriteLine($"Массив из {size} элементов: {string.Join(", ", myArr )} , Сумма нечетных элементов массива = {sum}  ");