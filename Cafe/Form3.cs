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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<string> list;

    public Form3 (List <string> list)
        {
            this.list = list;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UploadOrderList();
        }

        private void UploadOrderList()
        {
            listBox1.Items.Clear();
            var summ = 0;
            var orders = Program.OrderDict;
            foreach (var order in orders)
            {
                if (order.Value != 0)
                {
                    listBox1.Items.Add(order.Key + "X" + order.Value.ToString() + " " +
                                       Program.PriseDict[order.Key].ToString() + "р.");
                    summ += order.Value * Program.PriseDict[order.Key];
                }
            }

            label1.Text = "Сумма заказа " + summ.ToString() + "р.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                throw new AggregateException("Выберите блюдо, которое хотите удалить");
            else
            {
                var order = listBox1.SelectedItem.ToString().Split('X');
                Program.OrderDict[order[0]]--;
                UploadOrderList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();

            this.Close();
          
        }
    }
}
