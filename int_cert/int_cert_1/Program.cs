void ShowNumbers (int start, int end)
{
    // Базовый случай
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    // Рекурсивный случай
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(M, N); // start = 1, end = N
