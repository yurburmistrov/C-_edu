int FuncAckerman(int n, int m)
{
    if (n == 0)

        return m + 1;

    else if (m == 0)

        return FuncAckerman(n - 1, 1);

    else
        return FuncAckerman(n - 1, FuncAckerman(n, m - 1));
}

Console.WriteLine(FuncAckerman(3, 5));