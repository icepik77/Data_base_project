using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовой_проект.entity;
using Курсовой_проект.Manager;
using Курсовой_проект.model;

namespace Курсовой_проект
{
    public partial class Form1 : Form
    {
        static public List<Options> alldata = new List<Options>();
        static public int row = 0;
        public Form1()
        {
            InitializeComponent();            
        }

      
       

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            int i = 0;
            foreach (var a in alldata) {

                //fm4.dataGridView1["ID", 0].Value = a.id;
                //fm4.dataGridView1["D1",  0].Value = a.D1;         
                fm4.dataGridView1.Rows.Add(a.id, a.N, a.n1,a.k_sliding, a.D1, a.material_belt,a.layers, a.U, a.gear_ratio,a.n2, a.D2, a.Type_frequency, a.speed_freequency,a.b,a.quantity_padding, a.lambda, a.D_medium,  a.L, a.a_infinity, a.arrow, a.B, a.delta, a.a, a.a1, a.y1);
                i++;
            }
            
            fm4.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Options a = new Options();

            //Считывание инфы
            a.id = Guid.NewGuid();
            a.Type_D1 = comboBox1.Text;
            a.U = Convert.ToDouble(textBox4.Text);
            a.N = Convert.ToDouble(textBox1.Text);
            a.n1 = Convert.ToDouble(textBox2.Text);    
            a.material_belt = comboBox2.Text;
            a.quantity_padding = Convert.ToInt32(comboBox3.Text);
            a.b = Convert.ToDouble(textBox6.Text);
            a.layers = comboBox4.Text;
            a.delta_belt = Convert.ToDouble(textBox7.Text);
            a.D1 = Convert.ToDouble(textBox12.Text);
            a.n2 = Convert.ToDouble(textBox8.Text);
            a.k_sliding = Convert.ToDouble(textBox3.Text);
            a.Type_L = comboBox7.Text;
            a.Type_frequency = comboBox8.Text;
            a.speed_freequency = Convert.ToDouble(textBox5.Text);
            a.a_infinity = Convert.ToDouble(textBox9.Text);
            a.arrow = Convert.ToDouble(textBox10.Text);
            a.B = Convert.ToDouble(textBox11.Text);



            //Расчет по формулам
            if (a.Type_D1 == "По формуле Северина")
            {
                a.D1 = 115 * Math.Pow((a.N * 1000) / a.n1, 1.0 / 3.0);
            }
            if (a.Type_D1 == "По ориентировочной скорости ")
            {
                a.U = Convert.ToDouble(textBox4.Text);
                a.D1 =  (1000 * 60 * a.U)/ (3.14 * a.n1);
            }
            if (a.Type_D1 == "По толщине ремня")
            {
                a.D1 = Convert.ToDouble(textBox12.Text);
            }
            a.gear_ratio = a.n1 / a.n2;
            a.D2 = a.D1 * (1 - a.k_sliding) * a.gear_ratio;
            a.a = 2 * (a.D1 + a.D2);
            a.U = 3.14 * a.D1 * a.n1 / (1000 * 60);
            if (a.Type_L == "По межосевому расстооянию") {
                a.L = 2 * a.a + 3.14 * ((a.D1 + a.D2) / 2) + (Math.Pow(a.D2 - a.D1, 2) / (4 * a.a));
            }
            if (a.Type_L == "По сравнительной долговечности")
            {
                a.L = (a.U*1000) / a.speed_freequency;
            }          
            a.D_medium = (a.D1 + a.D2) / 2;
            a.lambda = a.L - 3.14 * a.D_medium;
            a.delta = (a.D1 - a.D2) / 2;
            a.a = (a.lambda + Math.Pow(Math.Pow(a.lambda, 2) - 8 * Math.Pow(a.delta, 2), 1.0 / 2.0)) / 4;
            a.a1 = 180 - ((a.D2 - a.D1) / a.a) * 57;
            a.y1 = 180 - a.a1;
            alldata.Add(a);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options a = new Options();
            a.N = Convert.ToDouble(textBox1.Text);
            a.n1 = Convert.ToDouble(textBox2.Text);
            a.D1 = 115* Math.Pow((a.N * 1000) / a.n1, 1.0/ 3.0);
            string slovo = Convert.ToString(a.D1); 
            MessageBox.Show(
               slovo,
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options a = new Options();
            a.U = Convert.ToDouble(textBox4.Text);
            a.n1 = Convert.ToDouble(textBox2.Text);
            a.D1=(60000*a.U)/(3.14*a.n1);
            string slovo = Convert.ToString(a.D1);
            MessageBox.Show(
               slovo,
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }
    }
}
