//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32 (Console.ReadLine());

string ListNum(int n)
{
    if (n == 0) return String.Empty;
    return Convert.ToString(n) + " " + ListNum(n - 1);
}

Console.WriteLine(ListNum(number));
