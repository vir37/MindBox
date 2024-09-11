using System;

namespace FigureArea
{
    /// <summary>
    /// Класс фигуры - Круг
    /// </summary>
    public class Circle : Figure
    {
        #region Data
        private readonly int _radius;
        #endregion Data

        #region Constructors
        private Circle() : base("Круг") { }

        /// <summary>
        /// Публичный конструктор
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(int radius) : this()
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Значение радиуса должно быть больше нуля", nameof(radius));
            }
            this._radius = radius;
        }
        #endregion Constructors

        #region Overrides
        public override double GetArea()
        {
            return this._radius * this._radius * Math.PI;
        }
        #endregion Overrides
    }
}
