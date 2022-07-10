using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalc.Shapes
{
    public class Triangle : Shape
    {
        /// <summary>
        /// Первая сторона
        /// </summary>
        private double Side1 { get; }
        /// <summary>
        /// Вторая сторона
        /// </summary>
        private double Side2 { get; }
        /// <summary>
        /// Третья сторона
        /// </summary>
        private double Side3 { get; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle => CheckRightTriangle();

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentOutOfRangeException("Стороны должны быть положительными");
            }
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns></returns>
        protected override double GetSquareCalc()
        {
            double halfPerimetr = (Side1 + Side2 + Side3) / 2;

            return Math.Sqrt(halfPerimetr * (halfPerimetr - Side1) * (halfPerimetr - Side2) * (halfPerimetr - Side3));
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        private bool CheckRightTriangle()
        {
            double maxSide = new[] { Side1, Side2, Side3 }.Max();
            double maxSideSqr = maxSide * maxSide;

            return maxSideSqr + maxSideSqr == Side1 * Side1 + Side2 * Side2 + Side3 * Side3;
        }
    }
}
