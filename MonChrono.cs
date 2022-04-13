using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Chrono
{
    public partial class MonChrono : Form
    {
        private int sec = 0;
        private int min = 0;
        bool activation = false;
        int nbclick = 0;
        public MonChrono()
        {
            InitializeComponent();
        }

        private void btntst_Click(object sender, EventArgs e)
        {
            activation = !activation;
            timer1.Enabled = activation;
            if(activation)
            {
                btntst.Text = "Stop !";
            } else
            {
                btntst.Text = "Start !";
            }

               
        }

        private void label1_Click(object sender, EventArgs e)
        {
            nbclick++;
            label1.Text = "X _ X";
            if(nbclick == 5)
            {
              
                label1.Text = "è _ é";
            }
            if(nbclick== 7)
            {
                label1.Text = "STAPH!";
                nbclick = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            sec++;
            label1.Text = $"{min.ToString()} : {sec.ToString()}";
            if(sec.ToString() == "59")
            {
                min++;
                sec = 0;
            }
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0 : 0";
            sec = 0; 
            min = 0;
        }
    }
}
