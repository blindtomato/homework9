//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FunctionAkkerman(m - 1, 1);
    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FunctionAkkerman(m, n));