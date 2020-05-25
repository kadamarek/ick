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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form4 myForm = new Form4();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel1.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form5 myForm = new Form5();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel1.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form6 myForm = new Form6();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel1.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form4 myForm = new Form4();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel1.Controls.Add(myForm);
            myForm.Dock = DockStyle.Fill;
            myForm.Show();

        }
    }
}
