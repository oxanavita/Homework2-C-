﻿// Задача необязательная 2:

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

  Console.Write("Введите количество программистов: ");
        int n = int.Parse(Console.ReadLine());

        string result = GetProgrammerCountString(n);
        Console.WriteLine(result);

    static string GetProgrammerCountString(int count)
    {
        // Получаем последнюю цифру числа
        int lastDigit = count % 10;

        // Получаем предпоследнюю цифру числа (если она есть)
        int penultimateDigit = count / 10 % 10;

        // Проверяем особые случаи чисел от 11 до 19 (они склоняются одинаково)
        if (penultimateDigit == 1)
        {
            return $"{count} программистов";
        }

        // Определяем склонение в зависимости от последней цифры
        string suffix;
        switch (lastDigit)
        {
            case 1:
                suffix = " программист";
                break;
            case 2:
            case 3:
            case 4:
                suffix = " программиста";
                break;
            default:
                suffix = " программистов";
                break;
        }

        return $"{count}{suffix}";
    }