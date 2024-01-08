using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStartProject
{
    public partial class MoneyExchange : Form
    {
        public MoneyExchange()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes") 
            {
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtfile = @".\MoneyConv.txt"; //create the text file 
            FileStream fileStream = null; // create the variable filestream

            try
            {
                fileStream = new FileStream(txtfile, FileMode.Append); // here you can read the content of the file using fileStream
                StreamWriter writer = new StreamWriter(fileStream); // create a StreamWriter object to write to the specified FileStream

                if (textBox1.Text.Length < 2) // condition to chek if the user put something in textbox
                {
                    MessageBox.Show("Error \n Please put a number to convert.");
                }
                {
                    string Date = DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt"); // the variable Date receive the struct DateTime and the method Now allows show the actual date
                    string numFrom = textBox1.Text; 
                    if (fromCad.Checked) //condition to check if the radio button is selected.
                    {
                        string fCad = "CAD";
                        string tUsd = "USD";
                        string tEur = "EUR";
                        string tGbp = "GBP";
                        string tBrl = "BRL";
                        if (fromCad.Checked && toCad.Checked) 
                        {
                            MessageBox.Show("Please, select different currencies.");
                            writer.WriteLine($" The user select the same currency {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromCad.Checked && toUsd.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double usd = 0.74; // 3/30/2023 Thursday 11:03am
                            double convert = num * usd;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fCad} {numFrom}  =  {tUsd} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromCad.Checked && toEur.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double eur = 0.68; // 3/30/2023 Thursday 11:06am
                            double convert = num * eur;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fCad} {numFrom}  =  {tEur} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromCad.Checked && toGbp.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double gbp = 0.60; // 3/30/2023 Thursday 11:07am
                            double convert = num * gbp;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fCad} {numFrom}  =  {tGbp} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromCad.Checked && toBrl.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double brl = 3.79; // 3/30/2023 Thursday 11:08am
                            double convert = num * brl;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fCad} {numFrom}  =  {tBrl} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error \n Please select a currency to convert.");
                        }
                    }
                    if (fromUsd.Checked)
                    {
                        string fUsd = "USD";
                        string tCad = "CAD";
                        string tEur = "EUR";
                        string tGbp = "GBP";
                        string tBrl = "BRL";

                        if (fromUsd.Checked && toCad.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double cad = 1.35; // 3/30/2023 Thursday 11:12am
                            double convert = num * cad;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fUsd} {numFrom}  =  {tCad} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromUsd.Checked && toUsd.Checked)
                        {
                            MessageBox.Show("Please, select different currencies.");
                            writer.WriteLine($" The user select the same currency {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromUsd.Checked && toEur.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double eur = 0.92; // 3/30/2023 Thursday 11:14am
                            double convert = num * eur;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fUsd} {numFrom}  =  {tEur} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromUsd.Checked && toGbp.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double gbp = 0.81; // 3/30/2023 Thursday 11:15am
                            double convert = num * gbp;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fUsd} {numFrom}  =  {tGbp} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromUsd.Checked && toBrl.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double brl = 5.12; // 3/30/2023 Thursday 11:16am
                            double convert = num * brl;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fUsd} {numFrom}  =  {tBrl} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error \n Please select a currency to convert.");
                        }

                    }
                    if (fromEur.Checked)
                    {
                        string fEur = "EUR";
                        string tCad = "CAD";
                        string tUsd = "USD";
                        string tGbp = "GBP";
                        string tBrl = "BRL";
                        if (fromEur.Checked && toCad.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double cad = 1.48; // 3/30/2023 Thursday 11:29am
                            double convert = num * cad;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fEur} {numFrom}  =  {tCad} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromEur.Checked && toUsd.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double usd = 1.09; // 3/30/2023 Thursday 11:30am
                            double convert = num * usd;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fEur} {numFrom}  =  {tUsd} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();

                        }
                        else if (fromEur.Checked && toEur.Checked)
                        {
                            MessageBox.Show("Please, select different currencies.");
                            writer.WriteLine($" The user select the same currency {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromEur.Checked && toGbp.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double gbp = 0.88; // 3/30/2023 Thursday 11:33am
                            double convert = num * gbp;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fEur} {numFrom}  =  {tGbp} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromEur.Checked && toBrl.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double brl = 5.58; // 3/30/2023 Thursday 11:33am
                            double convert = num * brl;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fEur} {numFrom}  =  {tBrl} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error \n Please select a currency to convert.");
                        }
                    }
                    if (fromGbp.Checked)
                    {
                        string fGbp = "GBP";
                        string tCad = "CAD";
                        string tUsd = "USD";
                        string tEur = "EUR";
                        string tBrl = "BRL";
                        if (fromGbp.Checked && toCad.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double cad = 1.67; // 3/30/2023 Thursday 11:35am
                            double convert = num * cad;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fGbp} {numFrom}  =  {tCad} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromGbp.Checked && toUsd.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double usd = 1.24; // 3/30/2023 Thursday 11:36am
                            double convert = num * usd;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fGbp} {numFrom}  =  {tUsd} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromGbp.Checked && toEur.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double eur = 1.13; // 3/30/2023 Thursday 11:37am
                            double convert = num * eur;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fGbp} {numFrom}  =  {tEur} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromGbp.Checked && toGbp.Checked)
                        {
                            MessageBox.Show("Please, select different currencies.");
                            writer.WriteLine($" The user select the same currency {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromGbp.Checked && toBrl.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double brl = 6.33; // 3/30/2023 Thursday 11:39am
                            double convert = num * brl;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fGbp} {numFrom}  =  {tBrl} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error \n Please select a currency to convert.");
                        }
                    }
                    if (fromBrl.Checked)
                    {
                        string fBrl = "BRL";
                        string tCad = "CAD";
                        string tUsd = "USD";
                        string tEur = "EUR";
                        string tGbp = "GBP";
                        if (fromBrl.Checked && toCad.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double cad = 0.26; // 3/30/2023 Thursday 11:41am
                            double convert = num * cad;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fBrl} {numFrom}  =  {tCad} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromBrl.Checked && toUsd.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double usd = 0.20; // 3/30/2023 Thursday 11:42am
                            double convert = num * usd;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fBrl} {numFrom}  =  {tUsd} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();

                        }
                        else if (fromBrl.Checked && toEur.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double eur = 0.18; // 3/30/2023 Thursday 11:44am
                            double convert = num * eur;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fBrl} {numFrom}  =  {tEur} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromBrl.Checked && toGbp.Checked)
                        {
                            double num = Convert.ToDouble(textBox1.Text);
                            double gbp = 0.16; // 3/30/2023 Thursday 11:47am
                            double convert = num * gbp;
                            textBox2.Text = convert.ToString();
                            writer.WriteLine($"{fBrl} {numFrom}  =  {tGbp} {convert} {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else if (fromBrl.Checked && toBrl.Checked) 
                        {
                            MessageBox.Show("Please, select different currencies.");
                            writer.WriteLine($" The user select the same currency {Date}");
                            writer.Close();
                            writer.Dispose();
                        }
                        else 
                        {
                            MessageBox.Show("Error \n Please select a currency to convert.");
                        }
                    }
                }
            }
            catch (IOException ex1)
            {
                MessageBox.Show("Error \n" + ex1.Message);
            }
            finally { if (fileStream != null) fileStream.Close(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                textBox1.Text = " ";
            }
        }

        private void groupFrom_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = ""; // declare the variable message 
            FileStream fileStream = null;
            StreamReader reader = null; // using the class StreamRaeder and declare the variable reader
            try
            {
                fileStream = new FileStream(@".\MoneyConv.txt", FileMode.Open, FileAccess.Read); // give the permission to acess, open and read.
                reader = new StreamReader(fileStream); // the variable reader will receive fileStream

                while (reader.Peek() != -1) //the method peek will return the next character that it found, here we are saying that while Peek found a character teh variable message receives message plus reader.
                {
                    message += reader.ReadLine() + "\n";

                }
                string title = "Money Exchange by Daniel Scholtz";
                MessageBox.Show(message, title);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, please try again. \n" + ex.Message);
            }

            finally
            {
                if (fileStream != null) fileStream.Close();
            }
        }

        private DateTime startTime; // declare the global variables startTime and endTime
        private DateTime endTime;
        private void MoneyExchange_Load(object sender, EventArgs e)
        {
           startTime = DateTime.Now; //Start to counting the current time in  startTime
        }

        private void MoneyExchange_FormClosing(object sender, FormClosingEventArgs e)
        {
            endTime= DateTime.Now; //Store the current time as the end time
            TimeSpan interval = endTime - startTime; // Calculate the duration of time between the start and end times
            int Seconds = Convert.ToInt32(interval.TotalSeconds); // Convert the duration to seconds
            int Minutes = Seconds / 60; // Calculate the number of minutes in the duration and update the remaining seconds
            Seconds %= 60;
            if (Minutes >= 2) // Check if the duration is at least 2 minutes and display the usage time in minutes and seconds
            {
                MessageBox.Show($"Usage Time: {Minutes} minutes and {Seconds} seconds", "Time Spent");
            }
            else if (Minutes == 0) // Check if the duration is less than a minute and display the usage time in seconds
            {
                MessageBox.Show($"Usage Time: {Seconds} seconds", "Time Spent");
            }
            else // Display the usage time in minutes and seconds
            {
                MessageBox.Show($"Usage Time: {Minutes} minute and {Seconds} seconds", "Time Spent");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
