using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution_to_Gasprom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обьявление перменных
            // Импортируем данные из TextBox
            string value_textbox1 = textBox1.Text;
            int size_arr = Convert.ToInt16(value_textbox1);
            bool value_checkbox1 = checkBox1.Checked;
            bool value_checkbox2 = checkBox2.Checked;

            // Формирование массива
            for (int i = 0; i < size_arr; i++)
            {
                int number_column = i + 1;
                string text_column = "[" + number_column + "]";
                dataGridView1.Columns.Add(Convert.ToString(number_column), text_column);
            }
            /*
            if (value_checkbox1 == true)
            {
                dataGridView1.Rows.Add("column-1", "uuuuuuuuuuuuuuuuu");
            }
            else if (value_checkbox2 == true)
            {
                dataGridView1.Columns.Add("column-1", "sssssssssss");
            }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
        }
    }
}
