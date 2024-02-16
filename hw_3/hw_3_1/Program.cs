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
        
        while (number > 0) // Вычисление суммы цифр числа
        {
            sum += number % 10; // Добавление последней цифры к сумме
            number=number/10;
        }
    

    if (sum % 2 == 0)
        {
            break;
        }


    }
    
}

