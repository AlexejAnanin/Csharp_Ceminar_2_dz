// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите день недели: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay > 7 || weekDay < 1)
{
    System.Console.WriteLine("Такой день недели не существует");
}
else if (weekDay == 6 || weekDay == 7)
{
    System.Console.WriteLine("да");
}
else {
    System.Console.WriteLine("нет");
}
