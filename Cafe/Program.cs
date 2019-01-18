using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

        //something
        //something too
        //something three
        public static Dictionary<string,int> OrderDict = new Dictionary<string, int>();
        public static Dictionary<string, int> PriseDict = new Dictionary<string, int>
        {
            {"Борщ", 30},
            {"Солянка", 45},
            {"Щи", 20},
            {"Гороховый", 20},
            {"Картофельное пюре", 15},
            {"Макароны", 15},
            {"Гречка", 15},
            {"Капуста", 15},
            {"Котлета из курицы", 30},
            {"Отбивная из свинины", 45},
            {"Фрикадельки", 30},
            {"Вегетарианская котлета", 25},
            {"Сосиска в тесте", 20},
            {"Пирожок с мясом", 20},
            {"Пирожок с капустой", 20},
            {"Хот-Дог", 25},
            {"Клюквенный морс", 10},
            {"Черный чай", 5},
            {"Зеленый чай", 5},
            {"Кофе", 10}
        };

    }
}
