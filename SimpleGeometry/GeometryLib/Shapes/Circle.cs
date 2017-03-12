using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape, IPrintable
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Debug.Assert(radius > 0, "radius > 0");
            Radius = radius;
        }

        public override double area()
        {
            return Radius * Radius * Math.PI;
        }


        public override string Print()
        {
            return $"Circle: radius = {Radius}, area = {area()}";
        }
    }
}
