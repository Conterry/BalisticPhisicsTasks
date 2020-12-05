using System;

namespace Balistics
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;
            double V = double.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            bool Status = true;
            double BackForce = 0.95, DownForce = 9.8;
            Vector vector = new Vector(X, Y);
            double High = 1;
            double Vx = V;
            double Vy = V;

            Console.WriteLine(BalisticsFormulas.TimeMax(V, vector.Angle()));
            Console.WriteLine(BalisticsFormulas.HighHight(V, vector.Angle()));
            Console.WriteLine(BalisticsFormulas.HighLength(V, vector.Angle()));

            while (Status)
            {
                if(DeltaTime(StartTime) % 1/60 == 0)
                {
                    Vx -= Math.Sin(DownForce) + Math.Cos(BackForce);
                    Vy -= Math.Cos(DownForce) + Math.Sin(BackForce);
                    vector.x += Vx * DeltaTime(StartTime);
                    vector.y += Vy * DeltaTime(StartTime);

                    Console.WriteLine(vector.x);
                    Console.WriteLine(vector.y);
                }
                if(vector.y == 0)
                {
                    Status = false;
                }
            }
        }   
        
        public static double DeltaTime(DateTime StartTime) => DateTime.Now.Second - StartTime.Second;

    }

}
