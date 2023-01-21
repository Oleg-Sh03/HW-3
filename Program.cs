// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number < 100000)
{
    if((number % 10 == number / 10000) && ((number - (number / 10000 * 10000)) / 1000) == ((number - number % 10) % 100 / 10))
    Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Число должно быть пятизначным.");
}
