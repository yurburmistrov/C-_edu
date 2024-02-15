//  size - размер массива; minRange - мин. число в рандоме
// maxRange - макс. число в рандоме

// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateArray(int size, int minRange, int maxRange)
{
    int[] array = new int[size]; // Массив на size элементов
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = new Random().Next(minRange, maxRange + 1);


    }
    return array;
}

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        // && - "и" (апельсины И яблоки)
        if (arr[i] % 2 == 0)
        {

            count++;
        }
    }
    return count;
}


// Вызов метода
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
// int size = N, int minRange = 10, int maxRange = 90
int[] res = CreateArray(N, 100, 1000);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Total: {GetCount(res)}");
