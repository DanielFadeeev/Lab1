﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void task1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void task2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void task3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
        }

        private void task4_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.Show();
        }
    }
}
