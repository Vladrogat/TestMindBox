namespace SquareCalc
{
    public abstract class Shape
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Square => GetSquareCalc();

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns></returns>
        protected abstract double GetSquareCalc();
    }
}