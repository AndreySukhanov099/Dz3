//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координату X (первой точки)");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y (первой точки)");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z (первой точки)");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X (второй точки)");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y (второй точки)");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z (второй точки)");
int z2 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(Math.Sqrt(Math.Abs((x1-x2)*(x1-x2))+(Math.Abs((y1-y2)*(y1-y2))+(Math.Abs((z1-z2)*(z1-z2))))));
