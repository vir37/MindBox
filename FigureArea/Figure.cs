namespace FigureArea
{
    /// <summary>
    /// Базовый класс фигуры
    /// </summary>
    public abstract class Figure
    {
        #region Data
        private readonly string name;
        #endregion Data

        #region Constructors
        protected Figure(string name) 
        {
            this.name = name;
        }
        #endregion Constructors

        /// <summary>
        /// Наименование фигуры
        /// </summary>
        public string Name => this.name;
        /// <summary>
        /// Метод получения площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double GetArea();
    }
}
