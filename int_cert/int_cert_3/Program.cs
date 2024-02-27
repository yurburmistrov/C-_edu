int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
    }
    return array;
}

void PrintReversArray(int[] array, int j)
{
    if (j == 0)
    {
        Console.Write(array[j]);
        return;
    }
    Console.Write(array[j] + "; ");
    PrintReversArray(array, j - 1);
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N);
int j = N - 1;
Console.WriteLine($"Массив:  {string.Join("; ", res)} ");
Console.Write("Реверс массива: ");
PrintReversArray(res, j);