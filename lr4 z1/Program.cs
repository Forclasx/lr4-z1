using System;

class Program
{
    static double f(double x)
    {
        return Math.Pow(x, 3) - Math.Sin(x);
    }
    static void Main(string[] args)
    {
        Console.Write("введите a");
        double a = double.Parse(Console.ReadLine());
        Console.Write("введите b");
        double b = double.Parse(Console.ReadLine());

        double fa = f(a);
        double fb = f(b);

        if (fa > fb)
        {
            Console.WriteLine("ну типо час ночи а я не сплю.");
        }
        else if (fa < fb)
        {
            Console.WriteLine("Функция принимает наибольшее значение в точке b.");
        }
        else
        {
            Console.WriteLine("Функция принимает одинаковые значения в точках a и b.");
        }
    }

   
}
