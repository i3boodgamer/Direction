using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private Manager MainManager;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainManager = new Manager(Info_TB, Report_TB);
            MainManager.Chance = Convert.ToInt32(Chance_NUD.Value);
            MainManager.CountStudent = Convert.ToInt32(Count_NUD.Value);


            MainManager.AddQueue(new Queue(1, Queue1_LB));
            MainManager.AddQueue(new Queue(2, Queue2_LB));
            MainManager.AddQueue(new Queue(3, Queue3_LB));
            MainManager.AddQueue(new Queue(4, Queue4_LB));
            MainManager.AddQueue(new Queue(5,  Queue5_LB));

            MainManager.AddDirection(new Direction(Direction_TB));

            NoAuto_RB.Checked = true;


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            MainManager.CountStudent = Convert.ToInt32(Count_NUD.Value);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Chance_NUD_ValueChanged(object sender, EventArgs e)
        {
            MainManager.Chance = Convert.ToInt32(Chance_NUD.Value);
        }

        private void Step_B_Click(object sender, EventArgs e)
        {
            Timer_Tick(this, e);
        }

        private void Report_B_Click(object sender, EventArgs e)
        {
            MainManager.SetReport();
        }

        private void Auto_RB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void NoAuto_RB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SetMode(object sender, EventArgs e)
        {
            Step_B.Enabled = NoAuto_RB.Checked;
            Report_B.Enabled = NoAuto_RB.Checked;

            Timer.Enabled = Auto_RB.Checked;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MainManager.OnTimer();
        }
    }
}
