using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult.Comands
{
    /// <summary>
    /// команда для выхода из приложения
    /// </summary>
    class ComandExit : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandExit()
        {
            NameComand = "выход";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Environment.Exit(0);
            Console.WriteLine($"Программа завершена!");
        }
    }
}
