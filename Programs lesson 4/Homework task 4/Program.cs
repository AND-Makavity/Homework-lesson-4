/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
void Exponentiation()
{
    Console.Write($"Введите число возводимое в степень: ");
    int.TryParse(Console.ReadLine(), out int A);
    Console.Write($"Введите степень: ");
    int.TryParse(Console.ReadLine(), out int B);
    int exp = 1;
    for (int i = 1; i <= B; i++) exp *= A;
    Console.Write($"Число {A} в степени {B} равно: {exp}");
}

Exponentiation();

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Number = new Random().Next(10, 10000);

int SumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.Write($"\nСумма цифр числа {Number} равна {SumDigits(Number)}");

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] Array = new int[8];

void FillArray(ref int[] array)
{
    Console.WriteLine($"\nЗаполнение массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]} ");
    }
}
FillArray(ref Array);