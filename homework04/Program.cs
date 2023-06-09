﻿// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

// Задача необязательная 2:

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

            Console.Write("Введите число: ");
        string input = Console.ReadLine();

        double number = 0.0;

        if (input != null && double.TryParse(input, out number))
        {
            double result = RemoveSecondDigit(number);

            if (result == number)
            {
                Console.WriteLine("Нет второй цифры слева.");
            }
            else
            {
                Console.WriteLine($"Результат: {result}");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод числа.");
        }

    static double RemoveSecondDigit(double number)
    {
        // Проверяем, является ли число целым или вещественным
        if (number % 1 == 0)
        {
            // Число является целым
            int num = (int)number;

            // Преобразуем число в строку и удаляем вторую цифру слева
            string numString = num.ToString();
            if (numString.Length >= 3)
            {
                string newNumString = numString.Remove(1, 1);
                return int.Parse(newNumString);
            }
        }
        else
        {
            // Число является вещественным
            string numString = number.ToString();
            if (numString.Length >= 4)
            {
                string newNumString = numString.Remove(1, 1);
                return double.Parse(newNumString);
            }
        }

        return number;
    }