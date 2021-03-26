using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace engineer_gaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("engineer gaming"); //engineer gaming
            label1.Text = "engineer gaming"; //engineer gaming
            pictureBox1.Visible = true; //engineer gaming
            Size = new Size(625, 718);
        }
    }
}