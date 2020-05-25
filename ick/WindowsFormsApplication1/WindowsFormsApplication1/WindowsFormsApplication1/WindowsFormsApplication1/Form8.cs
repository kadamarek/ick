using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        Form2 f2;
        int co;
        public Form8(Form2 form2)
        {
            InitializeComponent();
            this.f2 = form2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (co <= 10)
            {
                progressBar1.Value = co++;
            }
            else
            {
                timer1.Enabled = false;
                f2.Flag = true;
                this.Close();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            co = 0;
            timer1.Enabled = true;
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (co != 11)
            {
                timer1.Enabled = false;
                f2.Flag = false;
            }
            else
            {
                timer1.Enabled = true;

            }
        }
    }
    
}
