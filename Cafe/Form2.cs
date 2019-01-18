using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        //LIST LIST LIST
        List<string> list = new List<string>();

        private void basket_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            
            //this.Hide();
            form3.ShowDialog();
            this.Close();

            
        }

        #region ОбработкаКнопок
        private void borsch_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Борщ"))
                Program.OrderDict.Add("Борщ", 1);
            else
                Program.OrderDict["Борщ"]++;
        }

        private void solyanka_Click(object sender, EventArgs e)
        {

            if (!Program.OrderDict.ContainsKey("Солянка"))
                Program.OrderDict.Add("Солянка", 1);
            else
                Program.OrderDict["Солянка"]++;
        }

        private void chi_Click(object sender, EventArgs e)
        {


            if (!Program.OrderDict.ContainsKey("Щи"))
                Program.OrderDict.Add("Щи", 1);
            else
                Program.OrderDict["Щи"]++;
        }

        private void goroh_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Гороховый"))
                Program.OrderDict.Add("Гороховый", 1);
            else
                Program.OrderDict["Гороховый"]++;
        }

        private void pure_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Картофельное пюре"))
                Program.OrderDict.Add("Картофельное пюре", 1);
            else
                Program.OrderDict["Картофельное пюре"]++;
        }

        private void makaroshki_Click(object sender, EventArgs e)
        {

            if (!Program.OrderDict.ContainsKey("Макароны"))
                Program.OrderDict.Add("Макароны", 1);
            else
                Program.OrderDict["Макароны"]++;
        }

        private void kapusta_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Капуста"))
                Program.OrderDict.Add("Капуста", 1);
            else
                Program.OrderDict["Капуста"]++;
        }

        private void grechka_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Гречка"))
                Program.OrderDict.Add("Гречка", 1);
            else
                Program.OrderDict["Гречка"]++;
        }

        private void kurKot_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Котлета из курицы"))
                Program.OrderDict.Add("Котлета из курицы", 1);
            else
                Program.OrderDict["Котлета из курицы"]++;
        }

        private void otbiv_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Отбивная из свинины"))
                Program.OrderDict.Add("Отбивная из свинины", 1);
            else
                Program.OrderDict["Отбивная из свинины"]++;
        }

        private void frik_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Фрикадельки"))
                Program.OrderDict.Add("Фрикадельки", 1);
            else
                Program.OrderDict["Фрикадельки"]++;
        }

        private void vegan_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Вегетарианская котлета"))
                Program.OrderDict.Add("Вегетарианская котлета", 1);
            else
                Program.OrderDict["Вегетарианская котлета"]++;
        }

        private void sosiska_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Сосиска в тесте"))
                Program.OrderDict.Add("Сосиска в тесте", 1);
            else
                Program.OrderDict["Сосиска в тесте"]++;
        }

        private void myasPirog_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Пирожок с мясом"))
                Program.OrderDict.Add("Пирожок с мясом", 1);
            else
                Program.OrderDict["Пирожок с мясом"]++;
        }

        private void kapustPirog_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Пирожок с капустой"))
                Program.OrderDict.Add("Пирожок с капустой", 1);
            else
                Program.OrderDict["Пирожок с капустой"]++;
        }

        private void hotdog_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Хот-Дог"))
                Program.OrderDict.Add("Хот-Дог", 1);
            else
                Program.OrderDict["Хот-Дог"]++;
        }

        private void mors_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Клюквенный морс"))
                Program.OrderDict.Add("Клюквенный морс", 1);
            else
                Program.OrderDict["Клюквенный морс"]++;
        }

        private void chai_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Черный чай"))
                Program.OrderDict.Add("Черный чай", 1);
            else
                Program.OrderDict["Черный чай"]++;
        }

        private void green_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Зеленый чай"))
                Program.OrderDict.Add("Зеленый чай", 1);
            else
                Program.OrderDict["Зеленый чай"]++;
        }

        private void kofe_Click(object sender, EventArgs e)
        {
            if (!Program.OrderDict.ContainsKey("Кофе"))
                Program.OrderDict.Add("Кофе", 1);
            else
                Program.OrderDict["Кофе"]++;
        }
        #endregion
    }
}
