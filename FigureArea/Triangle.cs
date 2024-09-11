using System;

namespace FigureArea
{
    /// <summary>
    /// Класс фигуры - Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        #region Data
        /// <summary>
        /// Сторона A
        /// </summary>
        private readonly int _sideA;
        /// <summary>
        /// Сторона B
        /// </summary>
        private readonly int _sideB;
        /// <summary>
        /// Сторона C
        /// </summary>
        private readonly int _sideC;
        #endregion Data

        #region Constructors
        private Triangle() : base("Треугольник") 
        { }

        public Triangle(int sideA, int sideB, int sideC) : this()
        {
            if (sideA <= 0)         throw new ArgumentException("Неверно задана длина стороны", nameof(sideA));
            else if (sideB <= 0)    throw new ArgumentException("Неверно задана длина стороны", nameof(sideB));
            else if (sideC <= 0)    throw new ArgumentException("Неверно задана длина стороны", nameof(sideC)); 
            else if ( sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
            {
                throw new ArgumentException("В треугольнике сумма длин любых двух сторон должна быть больше длины третьей стороны");
            }
            (this._sideA, this._sideB, this._sideC) = (sideA, sideB, sideC);
        }
        #endregion Constructors

        #region Overrides
        public override double GetArea()
        {
            if (this.IsRectangular(out int katetA, out int katetB))
            {
                return (katetA * katetB) / 2;
            }
            else
            {
                int p = (this._sideA + this._sideB + this._sideC) / 2;
                return Math.Sqrt(p * (p - this._sideA) * (p - this._sideB) * (p - this._sideC));
            }
            
        }
        #endregion Overrides

        #region PrivateMethods
        /// <summary>
        /// Метод проверки, что треугольник является прямоугольным
        /// </summary>
        /// <param name="katetA">Длина катета 1 при условии, что треугольник прямоугольный</param>
        /// <param name="katetB">Длина катета 2 при условии, что треугольник прямоугольный</param>
        /// <returns>True - прямоугольный, False - нет</returns>
        private bool IsRectangular(out int katetA, out int katetB)
        {
            int sideA2 = this._sideA * this._sideA;
            int sideB2 = this._sideB * this._sideB;
            int sideC2 = this._sideC * this._sideC;
            
            if (sideA2 + sideB2 == sideC2)
            {
                (katetA, katetB) = (this._sideA, this._sideB);
                return true;
            }
            else if (sideB2 + sideC2 == sideA2)
            {
                (katetA, katetB) = (this._sideB, this._sideC);
                return true;
            }
            else if (sideA2 + sideC2 == sideB2)
            {
                (katetA, katetB) = (this._sideA, this._sideB);
                return true;
            }
            (katetA, katetB) = (default(int), default(int));
            return false;
        }
        #endregion PrivateMethods
    }
}
