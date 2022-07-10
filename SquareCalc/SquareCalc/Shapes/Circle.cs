using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalc.Shapes
{
    public class Circle: Shape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double radius)
        {  
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть положительным");
            }
            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        protected override double GetSquareCalc() => Math.PI * Radius * Radius;

    }
}
