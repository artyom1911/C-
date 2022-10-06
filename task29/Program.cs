// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] myArr = new int [size];

for (int i=0; i < myArr.Length; i+=1)
{
    Console.Write($"Введите значение элимента под индексом {i} = ");
    myArr[i]= Convert.ToInt32(Console.ReadLine());;
    
}

    Console.WriteLine($"Массив из {size} элементов: {string.Join(", ", myArr )} ");

