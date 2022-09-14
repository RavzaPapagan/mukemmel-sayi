﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            int toplam = 0;
            for (int i = 1; i <= sayi / 2; i++)
            {

                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (sayi == toplam)
            {
                MessageBox.Show("Girdiğiniz Sayı Bir Mükemmel Sayıdır");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Sayı Bir Mükemmel Sayı Değildir");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi;
            int toplam;
            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 2; i <= sayi; i++)
            {
                toplam = 0;
                for (int j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        toplam = toplam + j;
                    }
                }

                if (i == toplam)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
    }

