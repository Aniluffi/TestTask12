using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс для хранения точек
    /// </summary>
    class Point
    {
        /// <summary>
        /// поле для хранения x вершины
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// поле для хранения y вершины
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// метод для превращения в строку
        /// </summary>
        /// <returns>строку</returns>
        public override string ToString()
        {
            return $"( {X} ; {Y} )";
        }
    }
}
