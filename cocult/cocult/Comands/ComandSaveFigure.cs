using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult.Comands
{
    /// <summary>
    /// команда сохранения файла
    /// </summary>
    class ComandSaveFigure : IComand
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
        /// <param name="paths">список со всеми сохраненными файлами</param>
        public ComandSaveFigure(List<string> paths,ListFigure<Figure> _listEnteredShapes)
        {
            NameComand = "сохранить";
            this._paths = paths;
            this._listEnteredShapes = _listEnteredShapes;
        }

        /// <summary>
        /// команда для сохранения фигур
        /// </summary>
        /// <param name="data">путь файла</param>
        public void Execute(string data)
        {
            try
            {
                using (StreamWriter str = new StreamWriter(data, append: true))
                {
                    if (!_paths.Contains(data)) _paths.Add(data);
                    foreach (var el in _listEnteredShapes)
                    {
                        str.WriteLine(el.ToString());
                    }
                    _listEnteredShapes.Clear();
                    Console.Clear();
                    Console.WriteLine("Данные сохранены");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Не корректный файл {ex}");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("В это место нельзя сохранить файл или этот путь недостижим");
            }
        }
    }
}
