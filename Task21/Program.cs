// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите: ");
int z2 = Convert.ToInt32(Console.ReadLine());
// double Distance(int xa, int ya, int za, int xb, int yb, int zb);
// double distance = Distance(x1, y1, z1, x2, y2, z2);
int catX = x1 - x2;
int catY = y1 - y2;
int catZ = z1 - z2;
double result = Math.Sqrt(catX * catX + catY * catY + catZ * catZ);
// return result;

double RResult = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({x1}, {y1}, {z1},), B ({x2}, {y2}, {z2}), -> {RResult}");
