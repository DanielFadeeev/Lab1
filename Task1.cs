using System;
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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btnCalculateTriangle_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) &&
                 double.TryParse(txtB.Text, out double b) &&
                 double.TryParse(txtC.Text, out double c))
            {
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                txtTriangleArea.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные числа в поля A, B и C.", "Ошибка ввода");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
