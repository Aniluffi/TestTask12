using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с квадратом
    /// </summary>
    class Square :Figure
    {
        /// <summary>
        /// название фигуры
        /// </summary>
        public static readonly string name = "квадрат";

        /// <summary>
        /// поле хранящее длину стороны квадрата
        /// </summary>
        public double A {  get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">ввод стороны квадрата</param>
        public Square(double a)
        {
            this.A = a;
        }

        public Square(List<int> n)
        {
            A = n[0];
        }

        /// <summary>
        /// метод для вычисления площади квадрата
        /// </summary>
        /// <returns>возращает площадь</returns>
        public override double S()
        {
            return MathGeometry.SquareS(A);
        }

        /// <summary>
        /// метод для вычисления периметра квадрата
        /// </summary>
        /// <returns>возращает периметр</returns>
        public override double P()
        {
            return MathGeometry.SquareP(A);
        }

        /// <summary>
        /// метод для вывода информации о квадрате
        /// </summary>
        public override string ToString()
        {
           return $"Квадрат A = {A}";
        }
    }
}
