using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapesAll.Interface;

namespace Shapes.ShapesAll
{
    public class CircleCalculator : ICalculateShapes
    {
        public CircleCalculator(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public double Calculate()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
