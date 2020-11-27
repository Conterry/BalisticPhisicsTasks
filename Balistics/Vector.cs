using System;
using System.Collections.Generic;
using System.Text;

namespace Balistics
{
    public struct Vector
    {
        public double x;
        public double y;

        public Vector(double X, double Y)
        {
            this.x = X;
            this.y = Y;
        }

        public override string ToString() => "(" + x + ";" + y + ")";

        public double Length()
            => Math.Pow(this.x * this.x + this.y * this.y, 0.5);

        public double Angle()
        {

            double radians = Math.Atan2(y, x);
            double angle = radians * (180 / Math.PI);
            return angle;

        }


    }
}
