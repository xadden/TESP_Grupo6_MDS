﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMetodologia
{
    public partial class Register_medical_details : Form
    {
        public Register_medical_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage frm = new Homepage();
            frm.Show();
        }

        private void btnsavedetails_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("Details Saved.");
        }
    }
}
