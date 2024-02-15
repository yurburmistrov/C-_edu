while (true) // true == true
{
    Console.Write("Введите текст: ");
    string text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }
    int number; // Число или 0 (0 - если в строчке были буквы)
    if (int.TryParse(text, out number)) // == true, строчка состоит из цифр
    {
        int sum = 0;
        ...
if (sum % 2 == 0)
        {
            break;
        }
    }
}

