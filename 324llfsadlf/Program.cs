using System;

class Program
{
    static void Main(string[] args)
    { 
        Func<double, double> function = x => Math.Pow(x, 2) - Math.Sin(Math.PI * x);
        double a = 0.1;
        double b = 2.9;
        double h = 0.2;
        Console.WriteLine("Таблица значений функции:");
        for (double x = a; x <= b; x += h)
        {
            double y = function(x);
            Console.WriteLine($"x = {x:F1}, y = {y:F4}");
        }
    }
}