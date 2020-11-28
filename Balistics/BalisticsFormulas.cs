using System;
using System.Collections.Generic;
using System.Text;

namespace Balistics
{
    public class BalisticsFormulas
    {

        public static double TimeMax(double V, double alfa)
            => 2 * V * Math.Sin(alfa) / 10*0.95;

        public static double HighHight(double V, double alfa )
            => V * V * Math.Sin(alfa) * Math.Sin(alfa) / (2 * 10) * 0.95 ;

        public static double HighLength(double V, double alfa)
            => V * V * Math.Sin(2 * alfa) / 10;

        public static double MomentHight(double V, double alfa, int DeltaTime)
        {
            return V * Math.Cos(alfa)+10 * DeltaTime;
        }
    }
}
