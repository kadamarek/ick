using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Nazwa Systemu: Windows 8" + Environment.NewLine + " Wersja Systemu: 8.1 Pro" + Environment.NewLine + "Ilość Ram: 8000";
            this.panel1.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Win8;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "Nazwa Systemu: Debian" + Environment.NewLine + " Wersja Systemu: 7.4" + Environment.NewLine + "Ilość Ram: 2000";
            this.panel1.BackgroundImage = WindowsFormsApplication1.Properties.Resources.debian;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "Nazwa Systemu: Windows XP" + Environment.NewLine + " Wersja Systemu: XP" + Environment.NewLine + "Ilość Ram: 3000";
            this.panel1.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Winxp;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "Nazwa Systemu: Mac OSX" + Environment.NewLine + " Wersja Systemu: Pro" + Environment.NewLine + "Ilość Ram: 6000";
            this.panel1.BackgroundImage = WindowsFormsApplication1.Properties.Resources.Mac;

        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "Nazwa Systemu: Windows 10" + Environment.NewLine + " Wersja Systemu: 10 PRO" + Environment.NewLine + "Ilość Ram: 8000";
            this.panel1.BackgroundImage = WindowsFormsApplication1.Properties.Resources.win10;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
