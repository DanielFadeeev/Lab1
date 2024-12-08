using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmSumma : Form
    {
        public frmSumma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            int summa = a + b + c;
            txtSumma.Text = summa.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tasksBtn_Click_1(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
        }
    }
}
