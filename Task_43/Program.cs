// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] IntersectionPoint(double k1, double b1, double k2, double b2)
{
	double [] array = new double[2];
	array[0] = (b2 - b1) / (k1 - k2); // defined x
	array[1] = k1 * array[0] + b1; // defined y
	return array;
}
Console.Clear();

Console.Write("Enter k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "0");

double [] intersectionPoint = IntersectionPoint(k1, b1, k2, b2);

Console.Write($"Coordinates of the intersection point: ({intersectionPoint[0]}; {intersectionPoint[1]})");