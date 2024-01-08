using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStartProject
{
    public partial class IP4_Validator : Form
    {
        public IP4_Validator()
        {
            InitializeComponent();
        }

        private DateTime startTime;
        private DateTime endTime;
        private void IP4_Validator_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            label2.Text = DateTime.Now.ToLongDateString();
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
            textBox1.Text = "";
        }

        private void IP4_Validator_FormClosing(object sender, FormClosingEventArgs e)
        {
            endTime = DateTime.Now;
            TimeSpan interval = endTime - startTime;
            int Seconds = Convert.ToInt32(interval.TotalSeconds);
            int Minutes = Seconds / 60;
            Seconds %= 60;
            if (Minutes >= 2)
            {
                MessageBox.Show($"Usage Time: {Minutes} minutes and {Seconds} seconds", "Time Spent");
            }
            else if (Minutes == 0)
            {
                MessageBox.Show($"Usage Time: {Seconds} seconds", "Time Spent");
            }
            else
            {
                MessageBox.Show($"Usage Time: {Minutes} minute and {Seconds} seconds", "Time Spent");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // we will use the trim method to remove the spaces
            string IP = textBox1.Text.Trim();
            //regular expression that is used to check if a given string is a valid IP address.
            string check = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";


            try
            {


                if (Regex.IsMatch(IP, check)) // condiction to verify if the ip is valid 
                {
                    FileStream fileStream = new FileStream(@".\IP4_Validator.dat", FileMode.Append, FileAccess.Write);

                    BinaryWriter binaryOut = new BinaryWriter(fileStream);

                    binaryOut.Write(IP); // then write this in our binary file
                    binaryOut.Write(DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt"));
                    binaryOut.Close();


                    MessageBox.Show(IP + "\n" + "The IP is correct.", "Valid IP"); // then show this message to user
                }
                else
                {
                    MessageBox.Show(IP + "\n" + "The IP must have 4 bytes." + "\n" + "Integer number between 0 to 255" + "\n" + "Separated by a dot (255.255.255.255)", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
