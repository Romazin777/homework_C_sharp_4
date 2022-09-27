// ВСЕ ЗАДАЧИ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите степень для первого числа ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($" {A}, {B} -> {GetDegree(A, B)} ");
    
// double GetDegree( int numb, int degree)
// {
//     double result = Math.Pow(numb, degree);
//     return result;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($" {N} -> {GetSum(N)} ");
    
// int GetSum( int numb)
// {
//     int sum = 0;
//     while (numb > 0 )
//     {
//         sum = sum + (numb % 10);
//         numb = numb / 10;
//     }
//     return sum;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = massiv(8);    
Console.WriteLine($"{String.Join(", ", array)} -> [{String.Join(", ", array)}]");

int[] massiv(int size)
{
    int[] result = new int[size];
    for (int i = 0 ; i < size ; i++)
    {
        result[i] = new Random().Next(0, 50);
    }
    return result;
}