﻿using System;
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

            dataGridView2.Rows.Add("Прорезиненный", "Б-800", 3, "См, табл. 1.4", "С прослойками", 180, 140, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-800", 4, "См, табл. 1.4", "С прослойками", 224, 180, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-800", 5, "См, табл. 1.4", "С прослойками", 315, 224, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-800", 6, "См, табл. 1.4", "С прослойками", 355, 315, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-800", 3, "См, табл. 1.4", "Без прослоек", 140, 112, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-800", 4, "См, табл. 1.4", "Без прослоек", 200, 140, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-800", 5, "См, табл. 1.4", "Без прослоек", 250, 180, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-800", 6, "См, табл. 1.4", "Без прослоек", 315, 224, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-820", 3, "См, табл. 1.4", "С прослойками", 180, 140, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-820", 4, "См, табл. 1.4", "С прослойками", 224, 180, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-820", 5, "См, табл. 1.4", "С прослойками", 315, 224, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-820", 6, "См, табл. 1.4", "С прослойками", 355, 315, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-820", 3, "См, табл. 1.4", "Без прослоек", 140, 112, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-820", 4, "См, табл. 1.4", "Без прослоек", 200, 140, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-820", 5, "См, табл. 1.4", "Без прослоек", 250, 180, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "Б-820", 6, "См, табл. 1.4", "Без прослоек", 315, 224, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65", 3, "См, табл. 1.4", "С прослойками", 140, 112, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65", 4, "См, табл. 1.4", "С прослойками", 180, 140, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65", 5, "См, табл. 1.4", "С прослойками", 224, 180, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65", 6, "См, табл. 1.4", "С прослойками", 280, 200, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65", 3, "См, табл. 1.4", "Без прослоек", 125, 90, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65", 4, "См, табл. 1.4", "Без прослоек", 160, 112, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65", 5, "См, табл. 1.4", "Без прослоек", 200, 140, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65", 6, "См, табл. 1.4", "Без прослоек", 224, 180, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65-2", 3, "См, табл. 1.4", "С прослойками", 140, 112, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65-2", 4, "См, табл. 1.4", "С прослойками", 180, 140, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65-2", 5, "См, табл. 1.4", "С прослойками", 224, 180, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65-2", 6, "См, табл. 1.4", "С прослойками", 280, 200, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65-2", 3, "См, табл. 1.4", "Без прослоек", 125, 90, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65-2", 4, "См, табл. 1.4", "Без прослоек", 160, 112, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65-2", 5, "См, табл. 1.4", "Без прослоек", 200, 140, "не выбрано");
            dataGridView2.Rows.Add("Прорезиненный", "БКНЛ-65-2", 6, "См, табл. 1.4", "Без прослоек", 224, 180, "не выбрано");
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "0,4", "не выбрано", "не выбрано", "не выбрано", 28);
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "0,5", "не выбрано", "не выбрано", "не выбрано", 36);
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "0,6", "не выбрано", "не выбрано", "не выбрано", 45);
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "0,7", "не выбрано", "не выбрано", "не выбрано", 56);
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "0,8", "не выбрано", "не выбрано", "не выбрано", 63);
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "0,9", "не выбрано", "не выбрано", "не выбрано", 71);
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "1", "не выбрано", "не выбрано", "не выбрано", 80);
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "1,1", "не выбрано", "не выбрано", "не выбрано", 90);
            dataGridView2.Rows.Add("Синтетический", "не выбрано", "не выбрано", "1,2", "не выбрано", "не выбрано", "не выбрано", 100);

            dataGridView3.Rows.Add("Б-800", 3, "20...112", "С прослойками", "4,5");
            dataGridView3.Rows.Add("Б-800", 4, "20...250", "С прослойками", "6");
            dataGridView3.Rows.Add("Б-800", 5, "20...250", "С прослойками", "7,5");
            dataGridView3.Rows.Add("Б-800", 6, "80...250", "С прослойками", "9,0");
            dataGridView3.Rows.Add("Б-800", 3, "20...112", "Без прослоек", "3,75");
            dataGridView3.Rows.Add("Б-800", 4, "20...250", "Без прослоек", "5,0");
            dataGridView3.Rows.Add("Б-800", 5, "20...250", "Без прослоек", "6,25");
            dataGridView3.Rows.Add("Б-800", 6, "80...250", "Без прослоек", "7,5");
            dataGridView3.Rows.Add("Б-820", 3, "20...112", "С прослойками", "4,5");
            dataGridView3.Rows.Add("Б-820", 4, "20...250", "С прослойками", "6");
            dataGridView3.Rows.Add("Б-820", 5, "20...250", "С прослойками", "7,5");
            dataGridView3.Rows.Add("Б-820", 6, "80...250", "С прослойками", "9,0");
            dataGridView3.Rows.Add("Б-820", 3, "20...112", "Без прослоек", "3,75");
            dataGridView3.Rows.Add("Б-820", 4, "20...250", "Без прослоек", "5,0");
            dataGridView3.Rows.Add("Б-820", 5, "20...250", "Без прослоек", "6,25");
            dataGridView3.Rows.Add("Б-820", 6, "80...250", "Без прослоек", "7,5");
            dataGridView3.Rows.Add("БКНЛ-65", 3, "20...112", "С прослойками", "3,6");
            dataGridView3.Rows.Add("БКНЛ-65", 4, "20...250", "С прослойками", "4,8");
            dataGridView3.Rows.Add("БКНЛ-65", 5, "20...250", "С прослойками", "6,0");
            dataGridView3.Rows.Add("БКНЛ-65", 6, "80...250", "С прослойками", "7,2");
            dataGridView3.Rows.Add("БКНЛ-65", 3, "20...112", "Без прослоек", "3,0");
            dataGridView3.Rows.Add("БКНЛ-65", 4, "20...250", "Без прослоек", "4,0");
            dataGridView3.Rows.Add("БКНЛ-65", 5, "20...250", "Без прослоек", "5,0");
            dataGridView3.Rows.Add("БКНЛ-65", 6, "80...250", "Без прослоек", "6,0");

            dataGridView4.Rows.Add(63, 0.8, 0.3, 25);
            dataGridView4.Rows.Add(71, 1, 0.3, 32);
            dataGridView4.Rows.Add(80, 1, 0.3, 40);
            dataGridView4.Rows.Add(90, 1.2, 0.3, 50);
            dataGridView4.Rows.Add(100, 1.2, 0.3, 63);
            dataGridView4.Rows.Add(112, 1.2, 0.3, 71);
            dataGridView4.Rows.Add(125, 1.6, 0.4, 80);
            dataGridView4.Rows.Add(140, 1.6, 0.4, 90);
            dataGridView4.Rows.Add(160, 2, 0.5, 100);
            dataGridView4.Rows.Add(180, 2, 0.5, 112);
            dataGridView4.Rows.Add(200, 2.5, 0.6, 125);
            dataGridView4.Rows.Add(224, 2.5, 0.6, 140);
            dataGridView4.Rows.Add(250, 2.5, 0.8, 160);
            dataGridView4.Rows.Add(280, 3.2, 0.8, 180);
            dataGridView4.Rows.Add(315, 3.2, 1, 200);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
