// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine ("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if (N>=1)
    for (int i =1; i <= N; i++)
    {
        Console.Write("куб числа ");
        Console.Write(i);
        Console.WriteLine(" равен "+i*i );
    }
else
    for (int i =1; i >= N; i--)
    {
        Console.Write("куб числа ");
        Console.Write(i);
        Console.WriteLine(" равен "+i*i );
    }
   // Знаю, не корректно написана команда вывода (не смог написать в одну строку), подскажите как правильно