/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double formula_length ()

{
    Console.WriteLine("Точка 1 координаты X");
    int point_1_X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координаты Y");
    int point_1_Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координаты Z");
    int point_1_Z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Точка 2 координаты X");
    int point_2_X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координаты Y");
    int point_2_Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координаты Z");
    int point_2_Z = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow(point_1_X - point_2_X, 2) + Math.Pow(point_1_Y - point_2_Y, 2)+ Math.Pow(point_1_Z - point_2_Z, 2));
    return result;
}

double resulting = formula_length();
Console.WriteLine(resulting);
