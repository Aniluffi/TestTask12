using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс для работы с многоугольником
    /// </summary>
    class Polygon : Figure
    {
        /// <summary>
        /// название фигуры
        /// </summary>
        public static readonly string name = "многоугольник";

        /// <summary>
        /// лист для хранения всех вершин
        /// </summary>
        private List<Point> _polygonVertex;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="n">колличество вершин</param>
        public Polygon()
        {
            _polygonVertex = new List<Point>();
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="n">список с точками</param>
        public Polygon(List<int> n)
        {
            _polygonVertex = new List<Point>();
            for (int i = 0; i < n.Count - 1;i++)
            {
                if(i % 2 == 0 || i == 0)
                {
                    _polygonVertex.Add(new Point(n[i],n[i + 1]));
                }
            }    
             _polygonVertex.Add(_polygonVertex[0]);
        }


        /// <summary>
        /// метод вычисления периметра многоугольника
        /// </summary>
        /// <returns>возращает периметр многоугольника</returns>
        public override double P()
        {
            double p = 0;

            for(int i = 0; i < _polygonVertex.Count-1; i++)
            {
             p += MathGeometry.DistanceSquared(_polygonVertex[i],_polygonVertex[i+1]);
            }
            return p;
        }

        /// <summary>
        /// метод вычисления площадь многоугольника
        /// </summary>
        /// <returns>возращает площадь многоугольника</returns>
        public override double S()
        {
            double s = 0;
   
            for (int i = 1; i < _polygonVertex.Count - 2; i++)
            {  
               Triangle triangle = new Triangle(_polygonVertex[0],_polygonVertex[i],_polygonVertex[i + 1]);
               s += triangle.S();    
            }
            return s;
        }

        /// <summary>
        /// метод для преобразование в строку
        /// </summary>
        /// <returns>строку</returns>
        public override string ToString()
        {
            string str = "Многоугольник ";

            foreach (var el in _polygonVertex)
            {
               str += el.ToString();
            }
            return str;
        }
    }
}
