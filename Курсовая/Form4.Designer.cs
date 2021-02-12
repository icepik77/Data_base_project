
namespace Курсовой_проект
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_sliding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_belt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gear_ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speed_frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_fruequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitiy_padding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lambda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_medium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_infinity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.N,
            this.n1,
            this.k_sliding,
            this.D1,
            this.material_belt,
            this.layers,
            this.U,
            this.gear_ratio,
            this.n2,
            this.D2,
            this.speed_frequency,
            this.Type_fruequency,
            this.b,
            this.quantitiy_padding,
            this.lambda,
            this.D_medium,
            this.L,
            this.a_infinity,
            this.arrow,
            this.B1,
            this.delta,
            this.a,
            this.a1,
            this.y1});
            this.dataGridView1.Location = new System.Drawing.Point(26, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Геометрический расчет всех плоскоременных передач";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить передачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать передачу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // N
            // 
            this.N.HeaderText = "Мощность";
            this.N.Name = "N";
            // 
            // n1
            // 
            this.n1.HeaderText = "Частота вращения n1";
            this.n1.Name = "n1";
            // 
            // k_sliding
            // 
            this.k_sliding.HeaderText = "Коэффициент скольжения";
            this.k_sliding.Name = "k_sliding";
            // 
            // D1
            // 
            this.D1.HeaderText = "Диаметр меньшего шкива";
            this.D1.Name = "D1";
            // 
            // material_belt
            // 
            this.material_belt.HeaderText = "Материал ремня";
            this.material_belt.Name = "material_belt";
            // 
            // layers
            // 
            this.layers.HeaderText = "Наличие прослоек";
            this.layers.Name = "layers";
            // 
            // U
            // 
            this.U.HeaderText = "Скорость ремня";
            this.U.Name = "U";
            // 
            // gear_ratio
            // 
            this.gear_ratio.HeaderText = "Передаточное  число";
            this.gear_ratio.Name = "gear_ratio";
            // 
            // n2
            // 
            this.n2.HeaderText = "Частота вращения большего шкива";
            this.n2.Name = "n2";
            // 
            // D2
            // 
            this.D2.HeaderText = "Диаметр большего шкива";
            this.D2.Name = "D2";
            // 
            // speed_frequency
            // 
            this.speed_frequency.HeaderText = "Тип передачи";
            this.speed_frequency.Name = "speed_frequency";
            // 
            // Type_fruequency
            // 
            this.Type_fruequency.HeaderText = "Частота пробега";
            this.Type_fruequency.Name = "Type_fruequency";
            // 
            // b
            // 
            this.b.HeaderText = "Ширина ремня";
            this.b.Name = "b";
            // 
            // quantitiy_padding
            // 
            this.quantitiy_padding.HeaderText = "Число прокладок";
            this.quantitiy_padding.Name = "quantitiy_padding";
            // 
            // lambda
            // 
            this.lambda.HeaderText = "К. для длины ремня";
            this.lambda.Name = "lambda";
            // 
            // D_medium
            // 
            this.D_medium.HeaderText = "Среднее значение диаметров";
            this.D_medium.Name = "D_medium";
            // 
            // L
            // 
            this.L.HeaderText = "Длина ремня";
            this.L.Name = "L";
            // 
            // a_infinity
            // 
            this.a_infinity.HeaderText = "Предельное отклонение";
            this.a_infinity.Name = "a_infinity";
            // 
            // arrow
            // 
            this.arrow.HeaderText = "Стрела выпуклости";
            this.arrow.Name = "arrow";
            // 
            // B1
            // 
            this.B1.HeaderText = "Ширина шкива";
            this.B1.Name = "B1";
            // 
            // delta
            // 
            this.delta.HeaderText = "К. для a";
            this.delta.Name = "delta";
            // 
            // a
            // 
            this.a.HeaderText = "Межосевое расстояние";
            this.a.Name = "a";
            // 
            // a1
            // 
            this.a1.HeaderText = "Угол обхвата";
            this.a1.Name = "a1";
            // 
            // y1
            // 
            this.y1.HeaderText = "Угол между ветвями";
            this.y1.Name = "y1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_sliding;
        private System.Windows.Forms.DataGridViewTextBoxColumn D1;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_belt;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers;
        private System.Windows.Forms.DataGridViewTextBoxColumn U;
        private System.Windows.Forms.DataGridViewTextBoxColumn gear_ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn speed_frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_fruequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitiy_padding;
        private System.Windows.Forms.DataGridViewTextBoxColumn lambda;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_medium;
        private System.Windows.Forms.DataGridViewTextBoxColumn L;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_infinity;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn B1;
        private System.Windows.Forms.DataGridViewTextBoxColumn delta;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn a1;
        private System.Windows.Forms.DataGridViewTextBoxColumn y1;
    }
}