using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clc
{
    public partial class Form1 : Form
    {
        int islem = 0;
        double eded1, eded2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void duyme1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "1";
            
        }

        private void duyme2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "2";
            
        }

        private void duyme3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "3";
            
        }

        private void duyme4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "4";
            
        }

        private void duyme5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "5";
            
        }

        private void duyme6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "6";
            
        }

        private void duyme7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "7";
            
        }

        private void duyme8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "8";
            
        }

        private void duyme9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
           
                textBox1.Text = "";
                textBox1.Text += "9";
            
        }

        private void duyme0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += "0";
            
        }

        private void topla_Click(object sender, EventArgs e)
        {
            islem = 1;
            eded1 = Convert.ToDouble(textBox1.Text);
            sifirla();
      
            
        }
        public void sifirla()
        {
            textBox1.Text = "0";
        }
       
        public double hesabla()
        {
            double netice = 0;

            if (islem == 1)
            
                netice = eded1 + eded2;
                
            
            else if (islem == 2)
            
                netice = eded1 * eded2;
            
            else if(islem == 3)
            
                netice = eded1 / eded2;
            
            else if (islem == 4)
            
                netice = eded1 - eded2;
           
            else
            
                netice = 0;

                return netice;
            
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            sifirla();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            eded2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = hesabla().ToString();
        }

        private void vur_Click(object sender, EventArgs e)
        {
            islem = 2;
            eded1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            islem = 3;
            eded1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void cix_Click(object sender, EventArgs e)
        {
            islem = 4;
            eded1 = Convert.ToDouble(textBox1.Text);
            sifirla();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                textBox1.Text += data[i].ToString();
            }

            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void noqte_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
                textBox1.Text += ".";
            
        }

       
    }
}
