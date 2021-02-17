using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовой_проект.model;

namespace Курсовой_проект
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            Options options = new Options();

            options = Form1.alldata[row];
            Form1.alldata.Remove(options);          
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.row = dataGridView1.CurrentRow.Index;
            Form2 fm2 = new Form2();
            Options options = new Options();
            options = Form1.alldata[Form1.row];
            fm2.comboBox1.Text = options.Type_D1;
            fm2.textBox1.Text = Convert.ToString(options.N);
            fm2.textBox2.Text = Convert.ToString(options.n1);
            fm2.textBox4.Text = Convert.ToString(options.U);
            fm2.comboBox2.Text = options.type_belt;
            fm2.comboBox3.Text = Convert.ToString(options.quantity_padding);
            fm2.textBox6.Text = Convert.ToString(options.b);
            fm2.comboBox4.Text = Convert.ToString(options.layers);
            fm2.textBox7.Text = Convert.ToString(options.delta_belt);
            fm2.textBox12.Text = Convert.ToString(options.D1);
            fm2.textBox8.Text = Convert.ToString(options.n2);
            fm2.textBox3.Text = Convert.ToString(options.k_sliding);
            fm2.comboBox7.Text = options.Type_L;
            fm2.comboBox8.Text = options.Type_frequency;
            fm2.textBox5.Text = Convert.ToString(options.speed_freequency);
            fm2.textBox9.Text = Convert.ToString(options.a_infinity);
            fm2.textBox10.Text = Convert.ToString(options.arrow);
            fm2.textBox11.Text = Convert.ToString(options.B);


            this.Hide();
            fm2.ShowDialog();


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
