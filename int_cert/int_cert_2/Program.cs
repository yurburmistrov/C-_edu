int FuncAckerman(int n, int m)
{
    if (n == 0)

        return m + 1;

    else if (m == 0)

        return FuncAckerman(n - 1, 1);

    else
        return FuncAckerman(n - 1, FuncAckerman(n, m - 1));
    
}

Console.Write("Введите неотрицательноечисло n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {FuncAckerman(n,m)}");