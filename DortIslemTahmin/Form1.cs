using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslemTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int puan = 0;
        int sure = 300;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = sure.ToString();
            button1.Enabled = false;
            button2.Enabled = true;
            groupBox1.Visible = false;
            richTextBox1.Visible = false;
            textBox1.Focus();

            int sayi1, sayi2, islem;
            int a, b;
            int topla, cikar, carp, bol;
            textBox1.Clear();
            sayi1 = rastgele.Next(0, 51);
            sayi2 = rastgele.Next(1, 51);
            islem = rastgele.Next(1, 5);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();

            a = Convert.ToInt32(label1.Text);
            b = Convert.ToInt32(label2.Text);


            if(islem==1)
            {
                label3.Text = "+";
                topla = a + b;
                label5.Text = topla.ToString();
            }

            if(islem==2)
            {
                label3.Text = "-";
                cikar = a - b;
                label5.Text = cikar.ToString();
            }

            if(islem==3)
            {
                label3.Text = "*";
                carp = a * b;
                label5.Text = carp.ToString();
            }

            if(islem==4)
            {
                label3.Text = "/";
                bol = a / b;
                label5.Text = bol.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            if(label5.Text==textBox1.Text)
            {
                puan = puan + 10;
                label8.Text = puan.ToString();
            }

            if(label5.Text!=textBox1.Text)
            {
                puan = puan - 5;
                label8.Text = puan.ToString();
            }
        }

        private void button2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label9.Text = sure.ToString();

            if(sure==0)
            {
                timer1.Stop();
                button1.Enabled = false;
                button2.Enabled = false;
                
                
                MessageBox.Show("Süre doldu.Puanınız:"+label8.Text);
                button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Visible = false;
            groupBox1.Visible = true;
            richTextBox1.Visible = true;
            textBox1.Focus();

            sure = 300;
            label9.Text = sure.ToString();
            puan = 0;
            label8.Text = puan.ToString();
            label1.Text = "0";
            label2.Text = "0";
            textBox1.Clear();
           
        }
    }
}
