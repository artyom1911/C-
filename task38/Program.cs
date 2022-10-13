// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = 5;
double [] myArr = new double [size];

for (int i = 0 ; i < size; i+=1)
{
    myArr[i] = new Random().NextDouble()*10;
    myArr[i] = Math.Round(myArr[i],2);

}

double min = myArr.Min();
double max = myArr.Max();

double diff = max - min;
Math.Round(diff,2);

Console.WriteLine($"Массив из {size} элементов: {string.Join(", ", myArr )} , Минимальное = {min} , Максимальное = {max}. Разница = {diff} ");