// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Cubing(int number1, int number2)
{
    int cub = 1;

    for (int i = 0; i < number2; i += 1)
    {
        cub = cub * number1;
    }
    return cub;
}
int res = Cubing(3, 5);

Console.WriteLine(res);

// double res = Math.Pow (2,4);
// Console.WriteLine(res);