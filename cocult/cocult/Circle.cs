using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с кругом
    /// </summary>
    class Circle :Figure
    {
        /// <summary>
        /// название фигуры
        /// </summary>
        public static readonly string name = "круг";

        /// <summary>
        /// поле хранящее радиус круга
        /// </summary>
        public double R { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="r">ввод радиуса круга</param>
        public Circle(double r)
        {
            R = r;
        }

        public Circle(List<int> n)
        {
            R = n[0];
        }

        /// <summary>
        /// метод для вычисления площади круга
        /// </summary>
        /// <returns>возращает площадь</returns>
        public override double S()
        {
            return MathGeometry.CircleS(R);
        }

        /// <summary>
        /// метод для вычисления периметра круга
        /// </summary>
        /// <returns>возращает периметр</returns>
        public override double P()
        {
            return MathGeometry.CircleP(R);
        }

        /// <summary>
        /// метод для вывода информации о прямоугольнике
        /// </summary>
        public override string ToString()
        {
            return $"Круг R = {R}";
        }
    }
}
