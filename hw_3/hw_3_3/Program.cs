internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[N]; // Массив на size элементов
        for (int i = 0; i < N; i++)
        {
            array[i] = new Random().Next(1, 1000);
        }

        Console.WriteLine($"Массив1: [ {string.Join("; ", array)} ]");

        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }

        Console.WriteLine($"Массив2: [ {string.Join("; ", array)} ]");
    }
}