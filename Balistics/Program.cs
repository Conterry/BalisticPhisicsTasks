using System;

namespace Balistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            Vector vector = new Vector(X, Y);
            Console.WriteLine(BalisticsFormulas.TimeMax(V, vector.Angle()));
            Console.WriteLine(BalisticsFormulas.HighHight(V, vector.Angle()));
            Console.WriteLine(BalisticsFormulas.HighLength(V, vector.Angle()));
        }       
    }
}
