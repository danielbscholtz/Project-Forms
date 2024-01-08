using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStartProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoneyExchange obj = new MoneyExchange();
            obj.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TempConv obj = new TempConv();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IP4_Validator obj = new IP4_Validator();
            obj.Show();
        }
    }
}
