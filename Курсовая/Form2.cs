using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1.alldata[Form1.row].D1 = Convert.ToDouble(textBox2.Text);
            Form1.alldata[Form1.row].Type_D1 = comboBox1.Text;
            Form1.alldata[Form1.row].N = Convert.ToDouble(textBox1.Text);
            Form1.alldata[Form1.row].n1 = Convert.ToDouble(textBox2.Text);
            Form1.alldata[Form1.row].U = Convert.ToDouble(textBox4.Text);
            Form1.alldata[Form1.row].type_belt = comboBox2.Text;
            Form1.alldata[Form1.row].quantity_padding = Convert.ToInt32(comboBox3.Text);
            Form1.alldata[Form1.row].D1 = Convert.ToDouble(textBox12.Text);
            Form1.alldata[Form1.row].b = Convert.ToDouble(textBox6.Text);
            Form1.alldata[Form1.row].layers = comboBox4.Text;
            Form1.alldata[Form1.row].delta_belt = Convert.ToDouble(textBox7.Text);
            Form1.alldata[Form1.row].n2 = Convert.ToDouble(textBox8.Text);
            Form1.alldata[Form1.row].k_sliding = Convert.ToDouble(textBox3.Text);
            Form1.alldata[Form1.row].Type_L = comboBox7.Text;
            Form1.alldata[Form1.row].Type_frequency = comboBox8.Text;
            Form1.alldata[Form1.row].a_infinity = Convert.ToDouble(textBox9.Text);
            Form1.alldata[Form1.row].arrow = Convert.ToDouble(textBox10.Text);
            Form1.alldata[Form1.row].B = Convert.ToDouble(textBox11.Text);
            Form1.alldata[Form1.row].speed_freequency = Convert.ToDouble(textBox5.Text);




            //Расчет по формулам
            if (Form1.alldata[Form1.row].Type_D1 == "По формуле Северина")
            {
                Form1.alldata[Form1.row].D1 = 115 * Math.Pow((Form1.alldata[Form1.row].N * 1000) / Form1.alldata[Form1.row].n1, 1.0 / 3.0);
            }
            if (Form1.alldata[Form1.row].Type_D1 == "По ориентировочной скорости ")
            {
                Form1.alldata[Form1.row].U = Convert.ToDouble(textBox4.Text);
                Form1.alldata[Form1.row].D1 = (1000 * 60 * Form1.alldata[Form1.row].U)/ (3.14 * Form1.alldata[Form1.row].n1);
            }
            if (Form1.alldata[Form1.row].Type_D1 == "По толщине ремня")
            {
                Form1.alldata[Form1.row].D1 = Convert.ToDouble(textBox12.Text);
            }
            Form1.alldata[Form1.row].gear_ratio = Form1.alldata[Form1.row].n1 / Form1.alldata[Form1.row].n2;
            Form1.alldata[Form1.row].D2 = Form1.alldata[Form1.row].D1 * (1 - Form1.alldata[Form1.row].k_sliding) * Form1.alldata[Form1.row].gear_ratio;
            Form1.alldata[Form1.row].U = 3.14 * Form1.alldata[Form1.row].D1 * Form1.alldata[Form1.row].n1 / (1000 * 60);
            Form1.alldata[Form1.row].a = 2 * (Form1.alldata[Form1.row].D1 + Form1.alldata[Form1.row].D2);
            if (Form1.alldata[Form1.row].Type_L == "По межосевому расстооянию")
            {
                Form1.alldata[Form1.row].L = 2 * Form1.alldata[Form1.row].a + 3.14 * ((Form1.alldata[Form1.row].D1 + Form1.alldata[Form1.row].D2) / 2) + (Math.Pow(Form1.alldata[Form1.row].D2 - Form1.alldata[Form1.row].D1, 2) / (4 * Form1.alldata[Form1.row].a));
            }
            if (Form1.alldata[Form1.row].Type_L == "По сравнительной долговечности")
            {
                Form1.alldata[Form1.row].L = (Form1.alldata[Form1.row].U*1000) / Form1.alldata[Form1.row].speed_freequency;
            }
            Form1.alldata[Form1.row].D_medium = (Form1.alldata[Form1.row].D1 + Form1.alldata[Form1.row].D2) / 2;
            Form1.alldata[Form1.row].lambda = Form1.alldata[Form1.row].L - 3.14 * Form1.alldata[Form1.row].D_medium;
            Form1.alldata[Form1.row].delta = (Form1.alldata[Form1.row].D1 - Form1.alldata[Form1.row].D2) / 2;
            Form1.alldata[Form1.row].a = (Form1.alldata[Form1.row].lambda + Math.Pow(Math.Pow(Form1.alldata[Form1.row].lambda, 2) - 8 * Math.Pow(Form1.alldata[Form1.row].delta, 2), 1 / 2)) / 4;
            Form1.alldata[Form1.row].a1 = 180 - ((Form1.alldata[Form1.row].D2 - Form1.alldata[Form1.row].D1) / Form1.alldata[Form1.row].a) * 57;
            Form1.alldata[Form1.row].y1 = 180 - Form1.alldata[Form1.row].a1;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
