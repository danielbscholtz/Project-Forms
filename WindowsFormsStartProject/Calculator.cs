using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStartProject
{
    
    public partial class Calculator : Form
    {
        // I declare to constant variables for each number, dot and minus sinal.
        const decimal zero = 0, one = 1, two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, eight = 8, nine = 9;
        public string dot = ".";
        public string minus = "-";
        public int sinal = 0;
        calculatorClass calc = new calculatorClass(); // create a new object calc to be able call the method that I created in my class
        private void button8_Click(object sender, EventArgs e)
        {
            // for each number I put this condition 
            if (textBox1.Text.Length > 0) 
            {
                textBox1.Text += eight;
            }
            else
            {
                textBox1.Text = Convert.ToString(eight);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += seven;
            }
            else
            {
                textBox1.Text = Convert.ToString(seven);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool hasPoint = Regex.IsMatch(textBox1.Text, @"\."); // Regex to confirm if the dot point is in textbox
            if (textBox1.Text.Length > 0)
            {
                if(hasPoint == false)
                {
                    textBox1.Text += dot;
                }
               
            }
            else
            {
                MessageBox.Show("Please choose a number first");
                textBox1.Text = " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                button17.Visible = false;
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                textBox1.ReadOnly = true; 
                sinal = 1;
                calc.Operand1 = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = "";
                label1.Text = (calc.Operand1.ToString() + "+");

            }
            catch 
            {
                if (calc.Operand1 == 0)
                {
                    MessageBox.Show("Please select a number first");
                    calc.Clear();
                    textBox1.Text = "";
                    label1.Text = "";
                    button17.Visible = true;
                    button16.Visible = true;
                    button15.Visible = true;
                    button14.Visible = true;
                }
                calc.Operand1 = calc.CurrentValue;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += zero;
            }
            else
            {
                textBox1.Text = Convert.ToString(zero);
            }
        }

        private void button18_Click(object sender, EventArgs e) // The = button
        {
            string txtfile = @".\Calculator.txt";
            FileStream fileStream = null;
            try 
            {
                fileStream = new FileStream(txtfile, FileMode.Append);
                StreamWriter writer = new StreamWriter(fileStream);
                if (sinal == 1) // condicion to identify why operations the user click if sinal == 1 then the user click on +
                {
                    button17.Visible = true;
                    button16.Visible = true;
                    button15.Visible = true;
                    button14.Visible = true;
                    calc.Operand2 = Convert.ToDecimal(textBox1.Text); // get the second operand
                    calc.Add(calc.Operand1); // call my method 
                    textBox1.Text = calc.CurrentValue.ToString();
                    label1.Text = (calc.Operand1.ToString() + "+" + calc.Operand2.ToString() + "=" + calc.CurrentValue.ToString());
                    writer.WriteLine($"{label1.Text}");
                    writer.Close();
                    writer.Dispose();
                    textBox1.Text = "";
                }
                else if (sinal == 2) //then the user click on -
                {
                    button17.Visible = true;
                    button16.Visible = true;
                    button15.Visible = true;
                    button14.Visible = true;
                    calc.Operand2 = Convert.ToDecimal(textBox1.Text);
                    calc.Subtract(calc.Operand1); // call my method 
                    textBox1.Text = calc.CurrentValue.ToString();
                    label1.Text = (calc.Operand1.ToString() + "-" + calc.Operand2.ToString() + "= " + calc.CurrentValue.ToString());
                    writer.WriteLine($"{label1.Text}");
                    writer.Close();
                    writer.Dispose();
                    textBox1.Text = "";
                }
                else if (sinal == 3) //then the user click on *
                {
                    button17.Visible = true;
                    button16.Visible = true;
                    button15.Visible = true;
                    button14.Visible = true;
                    calc.Operand2 = Convert.ToDecimal(textBox1.Text);
                    calc.Multiply(calc.Operand1); // call my method 
                    textBox1.Text = calc.CurrentValue.ToString();
                    label1.Text = (calc.Operand1.ToString() + "*" + calc.Operand2.ToString() + "=" + calc.CurrentValue.ToString());
                    writer.WriteLine($"{label1.Text}");
                    writer.Close();
                    writer.Dispose();
                    textBox1.Text = "";
                }
                else if (sinal == 4) // then the user click on /
                {
                    button17.Visible = true;
                    button16.Visible = true;
                    button15.Visible = true;
                    button14.Visible = true;
                    calc.Operand2 = Convert.ToDecimal(textBox1.Text);
                    calc.Divide(calc.Operand1); // call my method 
                    textBox1.Text = calc.CurrentValue.ToString();
                    label1.Text = (calc.Operand1.ToString() + "/" + calc.Operand2.ToString() + "=" + calc.CurrentValue.ToString());
                    writer.WriteLine($"{label1.Text}");
                    writer.Close();
                    writer.Dispose();
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
                calc.Clear();
                textBox1.Text = "";
                label1.Text = "";
                button17.Visible = true;
                button16.Visible = true;
                button15.Visible = true;
                button14.Visible = true;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            calc.Clear();
            textBox1.Text = "";
            label1.Text = "";
            button17.Visible = true;
            button16.Visible = true;
            button15.Visible = true;
            button14.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                button17.Visible = false;
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                textBox1.ReadOnly = true;
                sinal = 2;
                calc.Operand1 = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = "";
                label1.Text = (calc.Operand1.ToString() + "-");
                button14.Visible = true;

            }
            catch
            {
                if (calc.Operand1 == 0)
                {
                    MessageBox.Show("Please select a number first");
                    calc.Clear();
                    textBox1.Text = "";
                    label1.Text = "";
                    button17.Visible = true;
                    button16.Visible = true;
                    button15.Visible = true;
                    button14.Visible = true;
                }
                calc.Operand1 = calc.CurrentValue;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                button17.Visible = false;
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                textBox1.ReadOnly = true;
                sinal = 3;
                calc.Operand1 = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = "";
                label1.Text = (calc.Operand1.ToString() + "*");

            }
            catch
            {
                if (calc.Operand1 == 0)
                {
                    MessageBox.Show("Please select a number first");
                    calc.Clear();
                    textBox1.Text = "";
                    label1.Text = "";
                    button17.Visible = true;
                    button16.Visible = true;
                    button15.Visible = true;
                    button14.Visible = true;
                }
                calc.Operand1 = calc.CurrentValue;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                button17.Visible = false;
                button16.Visible = false;
                button15.Visible = false;
                button14.Visible = false;
                textBox1.ReadOnly = true;
                sinal = 4;
                calc.Operand1 = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = "";
                label1.Text = (calc.Operand1.ToString() + "/");

            }
            catch
            {
                if (calc.Operand1 == 0)
                {
                    MessageBox.Show("Please select a number first");
                    calc.Clear();
                    textBox1.Text = "";
                    label1.Text = "";
                    button17.Visible = true;
                    button16.Visible = true;
                    button15.Visible = true;
                    button14.Visible = true;
                }
                calc.Operand1 = calc.CurrentValue;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                    textBox1.Text += minus;
            }
            else
            {
                MessageBox.Show("Error \n You need put the minus sinal before the number");
                textBox1.Text = "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += nine;
            }
            else
            {
                textBox1.Text = Convert.ToString(nine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += six;
            }
            else
            {
                textBox1.Text = Convert.ToString(six);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += five;
            }
            else
            {
                textBox1.Text = Convert.ToString(five);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += four;
            }
            else
            {
                textBox1.Text = Convert.ToString(four);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += three;
            }
            else
            {
                textBox1.Text = Convert.ToString(three);
            }
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += one;
            }
            else
            {
                textBox1.Text = Convert.ToString(one);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text += two;
            }
            else
            {
                textBox1.Text = Convert.ToString(two);
            }
        }
    }
}
