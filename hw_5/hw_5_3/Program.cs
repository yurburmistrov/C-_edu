char[] ConvertStringToCharArray(string str)
{
    char[] chars = new char[str.Length];
    // "hi" -> [,]
    // "hi" -> [str[0], str[1]]
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
        // chars = [], str = "hi"
        // chars[0] = str[0]; chars = ['h',]
        // chars[1] = str[1]; chars = ['h','i']
    }
    return chars;
}

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Введите строчку: ");
string str = Console.ReadLine();
Console.WriteLine($"Строка: {str}");
char[] chars = ConvertStringToCharArray(str);
Console.WriteLine($"Массив: [ {string.Join("; ", chars)} ]");


for (int i = 0; i < chars.Length / 2-1; i++)
{
    int j = chars.Length - 1 - i;
    if (str[i] != str[j])
    {
        Console.WriteLine("НЕ ПАЛИНДРОМ");
        break;
    }


    Console.WriteLine("ПАЛИНДРОМ");
}

