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
            this.Queue_GB = new System.Windows.Forms.GroupBox();
            this.Queue2_L = new System.Windows.Forms.Label();
            this.Queue4_L = new System.Windows.Forms.Label();
            this.Queue3_L = new System.Windows.Forms.Label();
            this.Queue5_L = new System.Windows.Forms.Label();
            this.Queue1_L = new System.Windows.Forms.Label();
            this.Mod_GB = new System.Windows.Forms.GroupBox();
            this.Report_L = new System.Windows.Forms.Label();
            this.Info_L = new System.Windows.Forms.Label();
            this.Direction_L = new System.Windows.Forms.Label();
            this.Info_TB = new System.Windows.Forms.TextBox();
            this.Report_TB = new System.Windows.Forms.TextBox();
            this.Chance_NUD = new System.Windows.Forms.NumericUpDown();
            this.appearance_GB = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.Report_B = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Direction_TB = new System.Windows.Forms.TextBox();
            this.Direction_TB2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Queue_GB.SuspendLayout();
            this.Mod_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chance_NUD)).BeginInit();
            this.appearance_GB.SuspendLayout();
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
            // Queue_GB
            // 
            this.Queue_GB.Controls.Add(this.Queue2_L);
            this.Queue_GB.Controls.Add(this.Queue4_L);
            this.Queue_GB.Controls.Add(this.Queue3_L);
            this.Queue_GB.Controls.Add(this.Queue5_L);
            this.Queue_GB.Controls.Add(this.Queue1_L);
            this.Queue_GB.Controls.Add(this.Queue1_LB);
            this.Queue_GB.Controls.Add(this.Queue5_LB);
            this.Queue_GB.Controls.Add(this.Queue3_LB);
            this.Queue_GB.Controls.Add(this.Queue4_LB);
            this.Queue_GB.Controls.Add(this.Queue2_LB);
            this.Queue_GB.Location = new System.Drawing.Point(4, 129);
            this.Queue_GB.Margin = new System.Windows.Forms.Padding(2);
            this.Queue_GB.Name = "Queue_GB";
            this.Queue_GB.Padding = new System.Windows.Forms.Padding(2);
            this.Queue_GB.Size = new System.Drawing.Size(979, 348);
            this.Queue_GB.TabIndex = 11;
            this.Queue_GB.TabStop = false;
            this.Queue_GB.Text = "Очереди";
            // 
            // Queue2_L
            // 
            this.Queue2_L.AutoSize = true;
            this.Queue2_L.Location = new System.Drawing.Point(794, 47);
            this.Queue2_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Queue2_L.Name = "Queue2_L";
            this.Queue2_L.Size = new System.Drawing.Size(67, 15);
            this.Queue2_L.TabIndex = 20;
            this.Queue2_L.Text = "Очередь 2";
            // 
            // Queue4_L
            // 
            this.Queue4_L.AutoSize = true;
            this.Queue4_L.Location = new System.Drawing.Point(597, 47);
            this.Queue4_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Queue4_L.Name = "Queue4_L";
            this.Queue4_L.Size = new System.Drawing.Size(67, 15);
            this.Queue4_L.TabIndex = 19;
            this.Queue4_L.Text = "Очередь 4";
            // 
            // Queue3_L
            // 
            this.Queue3_L.AutoSize = true;
            this.Queue3_L.Location = new System.Drawing.Point(401, 47);
            this.Queue3_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Queue3_L.Name = "Queue3_L";
            this.Queue3_L.Size = new System.Drawing.Size(67, 15);
            this.Queue3_L.TabIndex = 18;
            this.Queue3_L.Text = "Очередь 3";
            // 
            // Queue5_L
            // 
            this.Queue5_L.AutoSize = true;
            this.Queue5_L.Location = new System.Drawing.Point(202, 47);
            this.Queue5_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Queue5_L.Name = "Queue5_L";
            this.Queue5_L.Size = new System.Drawing.Size(67, 15);
            this.Queue5_L.TabIndex = 17;
            this.Queue5_L.Text = "Очередь 5";
            // 
            // Queue1_L
            // 
            this.Queue1_L.AutoSize = true;
            this.Queue1_L.Location = new System.Drawing.Point(5, 47);
            this.Queue1_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Queue1_L.Name = "Queue1_L";
            this.Queue1_L.Size = new System.Drawing.Size(67, 15);
            this.Queue1_L.TabIndex = 16;
            this.Queue1_L.Text = "Очередь 1";
            // 
            // Mod_GB
            // 
            this.Mod_GB.Controls.Add(this.Auto_RB);
            this.Mod_GB.Controls.Add(this.Step_B);
            this.Mod_GB.Controls.Add(this.NoAuto_RB);
            this.Mod_GB.Location = new System.Drawing.Point(374, 531);
            this.Mod_GB.Margin = new System.Windows.Forms.Padding(2);
            this.Mod_GB.Name = "Mod_GB";
            this.Mod_GB.Padding = new System.Windows.Forms.Padding(2);
            this.Mod_GB.Size = new System.Drawing.Size(187, 82);
            this.Mod_GB.TabIndex = 12;
            this.Mod_GB.TabStop = false;
            this.Mod_GB.Text = "Режимы";
            // 
            // Report_L
            // 
            this.Report_L.AutoSize = true;
            this.Report_L.Location = new System.Drawing.Point(1016, 68);
            this.Report_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Report_L.Name = "Report_L";
            this.Report_L.Size = new System.Drawing.Size(43, 15);
            this.Report_L.TabIndex = 14;
            this.Report_L.Text = "Отчет";
            this.Report_L.Click += new System.EventHandler(this.label1_Click);
            // 
            // Info_L
            // 
            this.Info_L.AutoSize = true;
            this.Info_L.Location = new System.Drawing.Point(7, 500);
            this.Info_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Info_L.Name = "Info_L";
            this.Info_L.Size = new System.Drawing.Size(159, 15);
            this.Info_L.TabIndex = 15;
            this.Info_L.Text = "Информация о действиях";
            // 
            // Direction_L
            // 
            this.Direction_L.AutoSize = true;
            this.Direction_L.Location = new System.Drawing.Point(33, 42);
            this.Direction_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Direction_L.Name = "Direction_L";
            this.Direction_L.Size = new System.Drawing.Size(64, 15);
            this.Direction_L.TabIndex = 21;
            this.Direction_L.Text = "Дирекция";
            this.Direction_L.Click += new System.EventHandler(this.Direction_L_Click);
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
            this.Chance_NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            // appearance_GB
            // 
            this.appearance_GB.Controls.Add(this.label10);
            this.appearance_GB.Controls.Add(this.label9);
            this.appearance_GB.Controls.Add(this.Chance_NUD);
            this.appearance_GB.Controls.Add(this.Count_NUD);
            this.appearance_GB.Location = new System.Drawing.Point(592, 533);
            this.appearance_GB.Margin = new System.Windows.Forms.Padding(2);
            this.appearance_GB.Name = "appearance_GB";
            this.appearance_GB.Padding = new System.Windows.Forms.Padding(2);
            this.appearance_GB.Size = new System.Drawing.Size(273, 80);
            this.appearance_GB.TabIndex = 13;
            this.appearance_GB.TabStop = false;
            this.appearance_GB.Text = "Появление";
            this.appearance_GB.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            this.Direction_TB.Location = new System.Drawing.Point(36, 60);
            this.Direction_TB.Multiline = true;
            this.Direction_TB.Name = "Direction_TB";
            this.Direction_TB.Size = new System.Drawing.Size(301, 64);
            this.Direction_TB.TabIndex = 24;
            // 
            // Direction_TB2
            // 
            this.Direction_TB2.Location = new System.Drawing.Point(387, 60);
            this.Direction_TB2.Multiline = true;
            this.Direction_TB2.Name = "Direction_TB2";
            this.Direction_TB2.Size = new System.Drawing.Size(342, 64);
            this.Direction_TB2.TabIndex = 25;
            this.Direction_TB2.TextChanged += new System.EventHandler(this.Direction_TB2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Дирекция";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 792);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direction_TB2);
            this.Controls.Add(this.Direction_TB);
            this.Controls.Add(this.Report_B);
            this.Controls.Add(this.appearance_GB);
            this.Controls.Add(this.Report_TB);
            this.Controls.Add(this.Info_TB);
            this.Controls.Add(this.Direction_L);
            this.Controls.Add(this.Info_L);
            this.Controls.Add(this.Report_L);
            this.Controls.Add(this.Queue_GB);
            this.Controls.Add(this.Mod_GB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Queue_GB.ResumeLayout(false);
            this.Queue_GB.PerformLayout();
            this.Mod_GB.ResumeLayout(false);
            this.Mod_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chance_NUD)).EndInit();
            this.appearance_GB.ResumeLayout(false);
            this.appearance_GB.PerformLayout();
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
        private System.Windows.Forms.GroupBox Queue_GB;
        private System.Windows.Forms.GroupBox Mod_GB;
        private System.Windows.Forms.Label Report_L;
        private System.Windows.Forms.Label Queue2_L;
        private System.Windows.Forms.Label Queue4_L;
        private System.Windows.Forms.Label Queue3_L;
        private System.Windows.Forms.Label Queue5_L;
        private System.Windows.Forms.Label Queue1_L;
        private System.Windows.Forms.Label Info_L;
        private System.Windows.Forms.Label Direction_L;
        public System.Windows.Forms.TextBox Info_TB;
        public System.Windows.Forms.TextBox Report_TB;
        private System.Windows.Forms.NumericUpDown Chance_NUD;
        private System.Windows.Forms.GroupBox appearance_GB;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Report_B;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox Direction_TB;
        private System.Windows.Forms.TextBox Direction_TB2;
        private System.Windows.Forms.Label label1;
    }
}

