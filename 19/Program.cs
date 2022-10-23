
// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число число");
int number = int.Parse(Console.ReadLine()!);

if(number < 100000 && number >= 10000)
{
    int number2;
    number2 = number / 10000 % 10+ number / 1000 % 10*10 + number / 100 % 10*100+number / 10 % 10*1000 + number % 10 *10000;
    if (number == number2)
    {

    System.Console.WriteLine("да");
    }
    else
    {
    System.Console.WriteLine("нет");
    }
}
else
{
System.Console.WriteLine("Введенное число не является пятизначным");
}