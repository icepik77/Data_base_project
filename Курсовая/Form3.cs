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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Тканевые прорезиненные", 30);
            dataGridView1.Rows.Add("Синтетические капроновые тип 1", 100);
            dataGridView1.Rows.Add("Синтетические капроновые тип 2", 50);

            dataGridView2.Rows.Add("Б-800 и Б-820", 3, "20...112", "С прослойками", "4,5");
            dataGridView2.Rows.Add("Б-800 и Б-820", 4, "20...250", "С прослойками", "6,0");
            dataGridView2.Rows.Add("Б-800 и Б-820", 5, "20...250", "С прослойками", "7,5");
            dataGridView2.Rows.Add("Б-800 и Б-820", 6, "80...250", "С прослойками", "9,0");
            dataGridView2.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 3, "20...112", "С прослойками", "3,6");
            dataGridView2.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 4, "20...250", "С прослойками", "4,8");
            dataGridView2.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 5, "20...250", "С прослойками", "6,0");
            dataGridView2.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 6, "80...250", "С прослойками", "7,2");
            dataGridView2.Rows.Add("Б-800 и Б-820", 3, "20...112", "Без прослоек", "3,75");
            dataGridView2.Rows.Add("Б-800 и Б-820", 4, "20...250", "Без прослоек", "5,0");
            dataGridView2.Rows.Add("Б-800 и Б-820", 5, "20...250", "Без прослоек", "6,25");
            dataGridView2.Rows.Add("Б-800 и Б-820", 6, "80...250", "Без прослоек", "7,5");
            dataGridView2.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 3, "20...112", "Без прослоек", "3,0");
            dataGridView2.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 4, "20...250", "Без прослоек", "4,0");
            dataGridView2.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 5, "20...250", "Без прослоек", "5,0");
            dataGridView2.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 6, "80...250", "Без прослоек", "6,0");

            dataGridView3.Rows.Add("Б-800 и Б-820", 3 , "Таблица 2", "Без прослоек", 140, 112, "Нет значений" );
            dataGridView3.Rows.Add("Б-800 и Б-820", 4, "Таблица 2", "Без прослоек", 200, 140, "Нет значений");
            dataGridView3.Rows.Add("Б-800 и Б-820", 5, "Таблица 2", "Без прослоек", 250, 180, "Нет значений");
            dataGridView3.Rows.Add("Б-800 и Б-820", 6, "Таблица 2", "Без прослоек", 315, 224, "Нет значений");
            dataGridView3.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 3, "Таблица 2", "Без прослоек", 125, 90, "Нет значений");
            dataGridView3.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 4, "Таблица 2", "Без прослоек", 160, 112, "Нет значений");
            dataGridView3.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 5, "Таблица 2", "Без прослоек", 200, 140, "Нет значений");
            dataGridView3.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 6, "Таблица 2", "Без прослоек", 224, 180, "Нет значений");
            dataGridView3.Rows.Add("Б-800 и Б-820", 3, "Таблица 2", "С прослойками", 180, 140, "Нет значений");
            dataGridView3.Rows.Add("Б-800 и Б-820", 4, "Таблица 2", "С прослойками", 224, 180, "Нет значений");
            dataGridView3.Rows.Add("Б-800 и Б-820", 5, "Таблица 2", "С прослойками", 315, 224, "Нет значений");
            dataGridView3.Rows.Add("Б-800 и Б-820", 6, "Таблица 2", "С прослойками", 355, 315, "Нет значений");
            dataGridView3.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 3, "Таблица 2", "С прослойками", 140, 112, "Нет значений");
            dataGridView3.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 4, "Таблица 2", "С прослойками", 180, 140, "Нет значений");
            dataGridView3.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 5, "Таблица 2", "С прослойками", 224, 180, "Нет значений");
            dataGridView3.Rows.Add("БКНЛ-65 и БКНЛ-65-2", 6, "Таблица 2", "С прослойками", 280, 200, "Нет значений");
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "0,4", "Нет значений", "Нет значений", "Нет значений", 28);
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "0,5", "Нет значений", "Нет значений", "Нет значений", 36);
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "0,6", "Нет значений", "Нет значений", "Нет значений", 45);
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "0,7", "Нет значений", "Нет значений", "Нет значений", 56);
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "0,8", "Нет значений", "Нет значений", "Нет значений", 63);
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "0,9", "Нет значений", "Нет значений", "Нет значений", 71);
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "1", "Нет значений", "Нет значений", "Нет значений", 80);
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "1,1", "Нет значений", "Нет значений", "Нет значений", 90);
            dataGridView3.Rows.Add("Синтетические", "Нет значений", "1,2", "Нет значений", "Нет значений", "Нет значений", 100);

            dataGridView4.Rows.Add(63,"0,8", "0,3", 25 );
            dataGridView4.Rows.Add(71, "1", "0,3", 32);
            dataGridView4.Rows.Add(80, "1", "0,3", 40);
            dataGridView4.Rows.Add(90, "1,2", "0,3", 50);
            dataGridView4.Rows.Add(100, "1,2", "0,3", 63);
            dataGridView4.Rows.Add(112, "1,2", "0,3", 71);
            dataGridView4.Rows.Add(125, "1,6", "0,4", 80);
            dataGridView4.Rows.Add(140, "0,8", "0,3", 90);
            dataGridView4.Rows.Add(160, "2", "0,5", 100);
            dataGridView4.Rows.Add(180, "2", "0,5", 112);
            dataGridView4.Rows.Add(200, "2,5", "0,6", 125);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
