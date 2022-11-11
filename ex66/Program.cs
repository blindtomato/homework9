// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int a, int b)
{
    if (a > b) return 0;
    return a + SumNumbers(a + 1, b);
}

if (m < n)
    Console.WriteLine(SumNumbers(m, n));
else
    Console.WriteLine(SumNumbers(n, m));
