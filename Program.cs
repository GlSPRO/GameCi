class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выйти из программы");
            Console.Write("Введите номер программы: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        PlayGuessTheNumber();
                        break;
                    case 2:
                        PrintMultiplicationTable();
                        break;
                    case 3:
                        PrintDivisors();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, выберите снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, выберите снова.");
            }
        }
    }

    static void PlayGuessTheNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);

        Console.WriteLine("Попробуйте угадать число от 0 до 100.");

        while (true)
        {
            Console.Write("Введите ваше предположение: ");
            if (int.TryParse(Console.ReadLine(), out int userGuess))
            {

                if (userGuess == randomNumber)
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {randomNumber}");
                    return;
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите целое число.");
            }
        }
    }

    static void PrintMultiplicationTable()
    {
        int[,] multiplicationTable = new int[10, 10];

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                multiplicationTable[i - 1, j - 1] = i * j;
            }
        }

        Console.WriteLine("Таблица умножения:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{multiplicationTable[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintDivisors()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"Делители числа {number}:");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
}