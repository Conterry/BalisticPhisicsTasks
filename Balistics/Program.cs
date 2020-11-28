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
                if(DeltaTime(StartTime) == 1)
                {
                    High = BalisticsFormulas.MomentHight(V, vector.Angle(), DeltaTime(StartTime));
                    Console.WriteLine(High);
                    StartTime = DateTime.Now;
                }
                /*if(High == 0)
                {
                    Status = false;
                }*/
            }
        }   
        
        public static int DeltaTime(DateTime StartTime) => DateTime.Now.Second - StartTime.Second;

    }

}
