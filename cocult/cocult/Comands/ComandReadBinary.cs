using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult.Comands
{
    class ComandReadBinary : IComand
    {
        /// <summary>
        /// список со всеми сохраненными файлами
        /// </summary>
        private List<string> _paths;

        /// <summary>
        /// список для хранения фигур
        /// </summary>
        ListFigure<Figure> _listEnteredShapes;

        /// <summary>
        /// название команды
        /// </summary>
        public string NameComand { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="paths">список сохраненных файлов</param>
        public ComandReadBinary(List<string> paths, ListFigure<Figure> _listEnteredShapes)
        {
            NameComand = "читать_бинар";
            this._paths = paths;
            this._listEnteredShapes = _listEnteredShapes;
        }

        /// <summary>
        /// команда для вывода сохраненных фигур в бинарном файле
        /// </summary>
        /// <param name="data">путь файла</param>
        public void Execute(string data)
        {
            Console.Clear();
            try
            {
                if (data == null)
                {
                    Console.WriteLine("Список файлов для чтения:\n");
                    for (int i = 0; i < _paths.Count; i++)
                    {
                        Console.WriteLine($"{i} {_paths[i]}");
                    }

                    int n = Convert.ToInt32(Console.ReadLine());

                    ReadFile(_paths[n]);
                }
                else ReadFile(data);
            }
            catch (IOException ex)
            {
                Console.Clear();
                Console.WriteLine($"Не корректный файл {ex}");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("не правильно введен файл или такого не существует");
            }
        }

        private void ReadFile(string path)
        {
            Console.Clear();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
            {
                ListFigure<Figure> list = new ListFigure<Figure>();

               

                Console.WriteLine($"Фигуры из файла {path}");
                while (fs.Position < fs.Length)
                { 
                 
                    string line = reader.ReadString();

                    Console.WriteLine(line);
                    string[] words = line.Split(" ", 2);
                    _listEnteredShapes.Clear();
                    CreateFigure(words[0], words[1]);
                }
            }
        }

        /// <summary>
        /// метод для создания обьектов figure из строки
        /// </summary>
        /// <param name="figur">название фигуры</param>
        /// <param name="parametrs">параметры фигуры</param>
        private void CreateFigure(string figur, string parametrs)
        {
            if (figur.ToLower() == Circle.name) _listEnteredShapes.Add(new Circle(App.ToParametrs(parametrs)));
            if (figur.ToLower() == Polygon.name) _listEnteredShapes.Add(new Polygon(App.ToParametrs(parametrs)));
            if (figur.ToLower() == Triangle.name) _listEnteredShapes.Add(new Triangle(App.ToParametrs(parametrs)));
            if (figur.ToLower() == Square.name) _listEnteredShapes.Add(new Square(App.ToParametrs(parametrs)));
            if (figur.ToLower() == Rectangle.name) _listEnteredShapes.Add(new Rectangle(App.ToParametrs(parametrs)));
        }
    }
}
