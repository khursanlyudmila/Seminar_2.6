/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Введите целые числа, которые будут являться значениями уравнений b1, k1, b2, k2 соответственно. Числа вводите через пробел!");
double[] arr = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

Console.WriteLine("При значениях: ");
double b1 = arr[0];
Console.WriteLine($"b1 = {arr[0]}");
double k1 = arr[1];
Console.WriteLine($"k1 = {arr[1]}");
double b2 = arr[2];
Console.WriteLine($"b2 = {arr[2]}");
double k2 = arr[3];
Console.WriteLine($"k2 = {arr[3]}");

double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");
