﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fQLNL qlnl = new fQLNL();
            qlnl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlymonan form2 = new Quanlymonan();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();  
            form5.ShowDialog();
        }
    }
}
