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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsStartProject
{
    public partial class TempConv : Form
    {
        public TempConv()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // if the first radio button is select the display of labels will be C to F
        {
            label2.Text = "°C";
            label3.Text = "°F";
        }

        private void fahrenToC_CheckedChanged(object sender, EventArgs e) // if the secnf is select the label display will be F to C
        {
            label2.Text = "°F";
            label3.Text = "°C";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e) //Convert Button
        {
            string txtfile = @".\TempConv.txt"; // create the text file in my folder
            FileStream fileStream = null; // create a variable filestream of the type FileStream and put the value null
            try
            {
                fileStream = new FileStream(txtfile, FileMode.Append); // The variable fileStream will receive a new object FileStrem that have two parameters, first the variable textfile that have the way to our TempConv.txt
                                                                       // and the second is FileMode.Append that means that every data will write in the fina of txtfile so that way we preserve the data that exist
                StreamWriter writer = new StreamWriter(fileStream); // create a new StreamWriter object and receive that parameter our variable fileStream this will write waht we need in our txt file
                
                {
                    string Date = DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt");
                    string numFrom = textBox1.Text;

                    if (!celsiusToF.Checked && !fahrenToC.Checked)
                    {
                        MessageBox.Show("Please select a type of convertion.");
                    }

                    if (double.TryParse(textBox1.Text, out double from)) //converts the value of textBox1 into a double number, If the conversion is successful,
                                                                         //the value will be stored in from variable
                    {
                        label5.Visible = false;
                        if (celsiusToF.Checked)
                        {
                            double ctF = 1.8;
                            double convert = (from * ctF) + 32; // simple calc to convert a number in celsius to far
                            textBox2.Text = convert.ToString(); 

                            if (convert == 212) 
                            {
                                string message = label5.Text = "Water Boils";
                                label5.ForeColor = Color.Red;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 104)
                            {
                                string message = label5.Text = "Hot Bath";
                                label5.ForeColor = Color.Red;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 98.6)
                            {
                                string message = label5.Text = "Body Temperature";
                                label5.ForeColor = Color.Green;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 86)
                            {
                                string message = label5.Text = "Beach weather";
                                label5.ForeColor = Color.Green;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 70)
                            {
                                string message = label5.Text = "Room temperature";
                                label5.ForeColor = Color.Green;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 50)
                            {
                                string message = label5.Text = "Cool Day";
                                label5.ForeColor = Color.Blue;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 32)
                            {
                                string message = label5.Text = "Freezing point of water";
                                label5.ForeColor = Color.Blue;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 0)
                            {
                                string message = label5.Text = "Very Cold Day";
                                label5.ForeColor = Color.Blue;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == -40)
                            {
                                string message = label5.Text = "Extremely Cold Day" + "\n" + convert;
                                label5.ForeColor = Color.Blue;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date} {message}");
                                writer.Close();
                                writer.Dispose();

                            }
                            else
                            {
                                label5.Visible = false;
                                writer.WriteLine($"{from}°C  = {convert}°F {Date}");
                                writer.Close();
                                writer.Dispose();
                            }

                        }
                        if (fahrenToC.Checked)
                        {
                            
                            double ftC = 0.5555555555555556;
                            double convert = (from - 32) * (ftC);
                            textBox2.Text = convert.ToString();

                            if (convert == 100)
                            {
                                string message = label5.Text = "Water Boils";
                                label5.ForeColor = Color.Red;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 40)
                            {
                                string message = label5.Text = "Hot Bath";
                                label5.ForeColor = Color.Red;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 37)
                            {
                                string message = label5.Text = "Body Temperature";
                                label5.ForeColor = Color.Green;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 30)
                            {
                                string message = label5.Text = "Beach weather";
                                label5.ForeColor = Color.Green;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 21)
                            {
                                string message = label5.Text = "Room temperature";
                                label5.ForeColor = Color.Green;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 10)
                            {
                                string message = label5.Text = "Cool Day";
                                label5.ForeColor = Color.Blue;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == 0)
                            {
                                string message = label5.Text = "Freezing point of water";
                                label5.ForeColor = Color.Blue;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == -18)
                            {
                                string message = label5.Text = "Very Cold Day";
                                label5.ForeColor = Color.Blue;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else if (convert == -40)
                            {
                                string message = label5.Text = "Extremely Cold Day" + "\n" + convert;
                                label5.ForeColor = Color.Blue;
                                label5.Visible = true;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date} {message}");
                                writer.Close();
                                writer.Dispose();
                            }
                            else
                            {
                                label5.Visible = false;
                                writer.WriteLine($"{from}°F  = {convert}°C {Date}");
                                writer.Close();
                                writer.Dispose();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for conversion.");
                        writer.WriteLine($" The user don't enter a valid number. - {Date}");
                        writer.Close();
                        writer.Dispose();
                    }
                }
            }
            catch (IOException ex1)
            {
                MessageBox.Show("Error \n" + ex1.Message);
            }
            finally { if (fileStream != null) fileStream.Close(); }
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
            string message = ""; // declare the variable message 
            FileStream fileStream = null;
            StreamReader reader = null; // using the class StreamRaeder and declare the variable reader
            try
            {
                fileStream = new FileStream(@".\TempConv.txt", FileMode.Open, FileAccess.Read); // give the permission to acess, open and read.
                reader = new StreamReader(fileStream); // the variable reader will receive fileStream

                while (reader.Peek() != -1) //the method peek will return the next character that it found, here we are saying that while Peek found a character teh variable message receives message plus reader.
                {
                    message += reader.ReadLine() + "\n";

                }
                string title = "Convert Temperature by Daniel Scholtz";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TempConv_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome!");
        }
    }
}
