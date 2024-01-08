using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStartProject
{
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random(); //Estou usando a classe Random do .NetFramework para gerar um objeto que nesse caso é "rnd" e criando uma nova instancia sem passar nenhum parametro.
            List<int> list = new List<int>(); // Criei uma lista para adicionar o numeros que preciso.
            for(int i = 0; i < 7; i++) //for loop para que me gere os sete numeros que preciso
            {
                int numberAbove = rnd.Next(0, 9); // o interio numberAbove recebe o meu objeto rnd e em seguida eu chamo o metodo .Next que ira me gerar um numero aleatorio entre 0 e 9 pois esses foram o sparametros que eu passei.
                list.Add(numberAbove);// adicionei o numeros que foram gerados  na minha lista
            }
            label2.Text = string.Join("",list);//estou fazendo o display dá minha lista na label2   

            Random random = new Random(); 
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                int rdmNumber = random.Next(1, 50); 

                for (int x = 0; x < randomNumbers.Count; x++) //um segundo loop para que meus numeros sejam unicos
                {
                    if (rdmNumber == randomNumbers[x]) // se o meu numero aleatorio gerado for igual a um numero já existente na minha lista então gere outro numero
                    {
                        rdmNumber = random.Next(1, 50); // aqui o comando para gerar outro numero se for igual a um já existente na lista
                        x = -1; // reset internal loop (condição de parada)
                    }
                }
                randomNumbers.Add(rdmNumber); // estou adicionando os numeros gerados dentro da minha lista
            }

            textBox1.Text = string.Join("\t\t", randomNumbers); // aqui é o local onde estou pedindo para que mostre a minha lista
            
            string txtfile = @".\LottoMax.txt";
            FileStream fileStream = null; // here I'm using the class FileStream from .NetFramework that alows operations of write and read.
            try
            {
                fileStream = new FileStream(txtfile, FileMode.Append); //fileStream receive the string txtfile that I declare above. The enumerator FileMode says how will open the file.
                StreamWriter writer = new StreamWriter(fileStream); // using the class StreamWriter declaring the local variable writer that receive fileStream
                {
                    int bonusNum = randomNumbers[7]; // the variable bonusNum receive the item in index 7 from list randomNumbers 
                    string Date = DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt"); // the variable Date receive the struct DateTime and the method Now allows show the actual date
                    string lottoName = "LottoMax"; 

                    writer.Write(lottoName + " - " + Date + ","); // the variable writer is using the method Write and We put in the parentheses
                    for (int i = 0; i < randomNumbers.Count - 1; i++) // loop for get each number in the list 
                    {
                        writer.Write(randomNumbers[i]); // say to put each number in the list in variable writer
                        if (i != randomNumbers.Count - 1) // condition to separete the numbers
                        {
                            writer.Write(",");
                        }
                    }
                    writer.Write(" Bonus " + bonusNum); // gets the bonus number (last number unique generate in our list)
                    writer.WriteLine(); 
                    writer.Close();
                }
            }
            catch(IOException ex1)
            {
                MessageBox.Show("Error \n" + ex1.Message);
            }
            finally { if (fileStream != null) fileStream.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LottoMax_Load(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = ""; // declare the variable message 
            FileStream fileStream = null;
            StreamReader reader = null; // using the class StreamRaeder and declare the variable reader
            try
            {
                fileStream = new FileStream(@".\LottoMax.txt", FileMode.Open, FileAccess.Read); // give the permission to acess, open and read.
                reader = new StreamReader(fileStream); // the variable reader will receive fileStream

                while (reader.Peek() != -1) //the method peek will return the next character that it found, here we are saying that while Peek found a character teh variable message receives message plus reader.
                {
                    message += reader.ReadLine() + "\n";

                }
                string title = "LottoMax by Daniel Scholtz";
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
    }
}
