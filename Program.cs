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

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($" {N} -> {GetSum(N)} ");
    
int GetSum( int numb)
{
    int sum = 0;
    while (numb > 0 )
    {
        sum = sum + (numb % 10);
        numb = numb / 10;
    }
    return sum;
}