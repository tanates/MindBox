using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.ShapesAll.Interface;

namespace Shapes.ShapesAll
{
   public class TriangleCalculator : ICalculateShapes
    {
        public TriangleCalculator(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Calculate()
        {
            

            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
        public bool IsRightTriangle()
        {
            // Проверяем условие прямоугольности треугольника
            return SideA * SideA + SideB * SideB == SideC * SideC || SideB * SideB + SideC * SideC == SideA * SideA || SideA * SideA + SideC * SideC == SideB * SideB;
        }
    }
}
