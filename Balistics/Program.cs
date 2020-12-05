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
            Vector vector = new Vector(X, Y);
            double High = 1;

            Console.WriteLine(BalisticsFormulas.TimeMax(V, vector.Angle()));
            Console.WriteLine(BalisticsFormulas.HighHight(V, vector.Angle()));
            Console.WriteLine(BalisticsFormulas.HighLength(V, vector.Angle()));

            while (Status)
            {
                if(DeltaTime(StartTime) == 1/60)
                {
                    vector.x += Math.Cos(V * DeltaTime(StartTime));
                    V -= 0.95;
                    Console.WriteLine(vector.x);
                }
                /*if(High == 0)
                {
                    Status = false;
                }*/
            }
        }   
        
        public static double DeltaTime(DateTime StartTime) => DateTime.Now.Second - StartTime.Second;

    }

}
