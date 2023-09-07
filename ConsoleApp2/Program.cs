using System;

class Program
{
    static void Main()
    {
        string inputString = string.Empty;

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Ввести строку");
            Console.WriteLine("2. Поиск подстроки");
            Console.WriteLine("3. Замена подстроки");
            Console.WriteLine("4. Переворот строки");
            Console.WriteLine("5. Вывести текущую строку");
            Console.WriteLine("6. Выход");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Введите строку: ");
                    inputString = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Введите подстроку для поиска: ");
                    string searchString = Console.ReadLine();
                    if (inputString.Contains(searchString))
                    {
                        Console.WriteLine($"Подстрока найдена в позиции {inputString.IndexOf(searchString)}");
                    }
                    else
                    {
                        Console.WriteLine("Подстрока не найдена.");
                    }
                    break;
                case 3:
                    Console.Write("Введите подстроку для замены: ");
                    string oldSubstring = Console.ReadLine();
                    Console.Write("Введите новую подстроку: ");
                    string newSubstring = Console.ReadLine();
                    inputString = inputString.Replace(oldSubstring, newSubstring);
                    Console.WriteLine("Подстрока успешно заменена.");
                    break;
                case 4:
                    char[] charArray = inputString.ToCharArray();
                    Array.Reverse(charArray);
                    inputString = new string(charArray);
                    Console.WriteLine("Строка успешно перевернута.");
                    break;
                case 5:
                    Console.WriteLine("Текущая строка: " + inputString);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}