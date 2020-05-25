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
    public partial class Form2 : Form
    {

        private bool flag;
        public Form2()
        {
            InitializeComponent();
            Flag = false;
        }

   

        OpenFileDialog ofd = new OpenFileDialog();

        public bool Flag { get => flag; set => flag = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            //ofd.ShowDialog();
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                textBox1.Text = ofd.SafeFileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(this);
            f8.ShowDialog();
            if(Flag==true)
            {

            }
        }


    }
}
