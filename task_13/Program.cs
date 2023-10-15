// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6

System.Console.Write("Введите целое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100)
    { System.Console.WriteLine(number);
        System.Console.WriteLine("Третьей цифры нет");
    }
    else
        {
           while (number > 1000)
           {
                number = number / 10;
           }
           System.Console.WriteLine($"Третья цифра числа:  {number % 10}");
        }

