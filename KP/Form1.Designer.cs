namespace KP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Queue1_LB = new System.Windows.Forms.ListBox();
            this.Queue5_LB = new System.Windows.Forms.ListBox();
            this.Queue3_LB = new System.Windows.Forms.ListBox();
            this.Queue4_LB = new System.Windows.Forms.ListBox();
            this.Queue2_LB = new System.Windows.Forms.ListBox();
            this.NoAuto_RB = new System.Windows.Forms.RadioButton();
            this.Auto_RB = new System.Windows.Forms.RadioButton();
            this.Step_B = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Info_TB = new System.Windows.Forms.TextBox();
            this.Report_TB = new System.Windows.Forms.TextBox();
            this.Chance_NUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.Report_B = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Direction_TB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chance_NUD)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Queue1_LB
            // 
            this.Queue1_LB.FormattingEnabled = true;
            this.Queue1_LB.Location = new System.Drawing.Point(5, 63);
            this.Queue1_LB.Margin = new System.Windows.Forms.Padding(2);
            this.Queue1_LB.Name = "Queue1_LB";
            this.Queue1_LB.Size = new System.Drawing.Size(163, 264);
            this.Queue1_LB.TabIndex = 1;
            this.Queue1_LB.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Queue5_LB
            // 
            this.Queue5_LB.FormattingEnabled = true;
            this.Queue5_LB.Location = new System.Drawing.Point(204, 63);
            this.Queue5_LB.Margin = new System.Windows.Forms.Padding(2);
            this.Queue5_LB.Name = "Queue5_LB";
            this.Queue5_LB.Size = new System.Drawing.Size(163, 264);
            this.Queue5_LB.TabIndex = 2;
            // 
            // Queue3_LB
            // 
            this.Queue3_LB.FormattingEnabled = true;
            this.Queue3_LB.Location = new System.Drawing.Point(404, 63);
            this.Queue3_LB.Margin = new System.Windows.Forms.Padding(2);
            this.Queue3_LB.Name = "Queue3_LB";
            this.Queue3_LB.Size = new System.Drawing.Size(163, 264);
            this.Queue3_LB.TabIndex = 3;
            // 
            // Queue4_LB
            // 
            this.Queue4_LB.FormattingEnabled = true;
            this.Queue4_LB.Location = new System.Drawing.Point(599, 63);
            this.Queue4_LB.Margin = new System.Windows.Forms.Padding(2);
            this.Queue4_LB.Name = "Queue4_LB";
            this.Queue4_LB.Size = new System.Drawing.Size(163, 264);
            this.Queue4_LB.TabIndex = 4;
            // 
            // Queue2_LB
            // 
            this.Queue2_LB.FormattingEnabled = true;
            this.Queue2_LB.Location = new System.Drawing.Point(796, 63);
            this.Queue2_LB.Margin = new System.Windows.Forms.Padding(2);
            this.Queue2_LB.Name = "Queue2_LB";
            this.Queue2_LB.Size = new System.Drawing.Size(163, 264);
            this.Queue2_LB.TabIndex = 5;
            // 
            // NoAuto_RB
            // 
            this.NoAuto_RB.AutoSize = true;
            this.NoAuto_RB.Location = new System.Drawing.Point(13, 46);
            this.NoAuto_RB.Margin = new System.Windows.Forms.Padding(2);
            this.NoAuto_RB.Name = "NoAuto_RB";
            this.NoAuto_RB.Size = new System.Drawing.Size(75, 19);
            this.NoAuto_RB.TabIndex = 7;
            this.NoAuto_RB.TabStop = true;
            this.NoAuto_RB.Text = "Вручную";
            this.NoAuto_RB.UseVisualStyleBackColor = true;
            this.NoAuto_RB.CheckedChanged += new System.EventHandler(this.SetMode);
            // 
            // Auto_RB
            // 
            this.Auto_RB.AutoSize = true;
            this.Auto_RB.Location = new System.Drawing.Point(13, 25);
            this.Auto_RB.Margin = new System.Windows.Forms.Padding(2);
            this.Auto_RB.Name = "Auto_RB";
            this.Auto_RB.Size = new System.Drawing.Size(118, 19);
            this.Auto_RB.TabIndex = 8;
            this.Auto_RB.TabStop = true;
            this.Auto_RB.Text = "Автоматически";
            this.Auto_RB.UseVisualStyleBackColor = true;
            this.Auto_RB.CheckedChanged += new System.EventHandler(this.Auto_RB_CheckedChanged);
            // 
            // Step_B
            // 
            this.Step_B.Location = new System.Drawing.Point(94, 46);
            this.Step_B.Margin = new System.Windows.Forms.Padding(2);
            this.Step_B.Name = "Step_B";
            this.Step_B.Size = new System.Drawing.Size(56, 22);
            this.Step_B.TabIndex = 9;
            this.Step_B.Text = "Шаг";
            this.Step_B.UseVisualStyleBackColor = true;
            this.Step_B.Click += new System.EventHandler(this.Step_B_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Queue1_LB);
            this.groupBox1.Controls.Add(this.Queue5_LB);
            this.groupBox1.Controls.Add(this.Queue3_LB);
            this.groupBox1.Controls.Add(this.Queue4_LB);
            this.groupBox1.Controls.Add(this.Queue2_LB);
            this.groupBox1.Location = new System.Drawing.Point(4, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(979, 348);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Очереди";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(794, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Очередь 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Очередь 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Очередь 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Очередь 5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Очередь 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Auto_RB);
            this.groupBox2.Controls.Add(this.Step_B);
            this.groupBox2.Controls.Add(this.NoAuto_RB);
            this.groupBox2.Location = new System.Drawing.Point(374, 531);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(187, 82);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режимы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1016, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Отчет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Информация о действиях";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Дирекция";
            // 
            // Info_TB
            // 
            this.Info_TB.Location = new System.Drawing.Point(9, 531);
            this.Info_TB.Multiline = true;
            this.Info_TB.Name = "Info_TB";
            this.Info_TB.ReadOnly = true;
            this.Info_TB.Size = new System.Drawing.Size(328, 249);
            this.Info_TB.TabIndex = 22;
            // 
            // Report_TB
            // 
            this.Report_TB.Location = new System.Drawing.Point(999, 86);
            this.Report_TB.Multiline = true;
            this.Report_TB.Name = "Report_TB";
            this.Report_TB.ReadOnly = true;
            this.Report_TB.Size = new System.Drawing.Size(328, 391);
            this.Report_TB.TabIndex = 23;
            // 
            // Chance_NUD
            // 
            this.Chance_NUD.Location = new System.Drawing.Point(185, 22);
            this.Chance_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Chance_NUD.Name = "Chance_NUD";
            this.Chance_NUD.Size = new System.Drawing.Size(64, 20);
            this.Chance_NUD.TabIndex = 24;
            this.Chance_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Chance_NUD.ValueChanged += new System.EventHandler(this.Chance_NUD_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Chance_NUD);
            this.groupBox3.Controls.Add(this.Count_NUD);
            this.groupBox3.Location = new System.Drawing.Point(592, 533);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(273, 80);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Режимы";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Кол-во студентов";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Вероятность появления 1 из";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(119, 46);
            this.Count_NUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Count_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_NUD.Name = "Count_NUD";
            this.Count_NUD.Size = new System.Drawing.Size(64, 20);
            this.Count_NUD.TabIndex = 25;
            this.Count_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count_NUD.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Report_B
            // 
            this.Report_B.Location = new System.Drawing.Point(999, 493);
            this.Report_B.Margin = new System.Windows.Forms.Padding(2);
            this.Report_B.Name = "Report_B";
            this.Report_B.Size = new System.Drawing.Size(328, 33);
            this.Report_B.TabIndex = 10;
            this.Report_B.Text = "Отчет";
            this.Report_B.UseVisualStyleBackColor = true;
            this.Report_B.Click += new System.EventHandler(this.Report_B_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Direction_TB
            // 
            this.Direction_TB.Location = new System.Drawing.Point(233, 60);
            this.Direction_TB.Multiline = true;
            this.Direction_TB.Name = "Direction_TB";
            this.Direction_TB.Size = new System.Drawing.Size(459, 64);
            this.Direction_TB.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 792);
            this.Controls.Add(this.Direction_TB);
            this.Controls.Add(this.Report_B);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Report_TB);
            this.Controls.Add(this.Info_TB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chance_NUD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Queue1_LB;
        private System.Windows.Forms.ListBox Queue5_LB;
        private System.Windows.Forms.ListBox Queue3_LB;
        private System.Windows.Forms.ListBox Queue4_LB;
        private System.Windows.Forms.ListBox Queue2_LB;
        private System.Windows.Forms.RadioButton NoAuto_RB;
        private System.Windows.Forms.RadioButton Auto_RB;
        private System.Windows.Forms.Button Step_B;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox Info_TB;
        public System.Windows.Forms.TextBox Report_TB;
        private System.Windows.Forms.NumericUpDown Chance_NUD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Report_B;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox Direction_TB;
    }
}

