using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TheInterface
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

         private int empty = 0;
         private Item[] itemsArr = new Item[5];


        public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };



        private void addToFileBtn_Click(object sender, EventArgs e)
        {
            string input = nameInput.Text + ", " + dayInput.Text + " ," + ageInput.Text + "\n";
            File.AppendAllText("userInput.txt", input);
            nameInput.Text = "";
            dayInput.Text = "";
            ageInput.Text = "";

        }

        private void loadFromFile_Click(object sender, EventArgs e)
        {
            // Read the file and display the first line
            StreamReader file = new StreamReader("userInput.txt");
            string line = file.ReadLine();
            file.Close();
            string[] details = line.Split(',');
             Days day = (Days) Enum.Parse(typeof(Days), details[1]);

            nameInput.Text = details[0];
            dayInput.Text = day.ToString();
            ageInput.Text = details[2];
        }

        private void ItemCreate_Click(object sender, EventArgs e)
        {
            Item item = new Cola();
        }

        private void colaBtn_Click(object sender, EventArgs e)
        {
            itemsArr[empty] = new Cola();
            try
            {
                empty++;
            }
            catch (IndexOutOfRangeException)
            {
                    MessageBox.Show("The array is full");
            }
        }
        
        private void kinleyBtn_Click(object sender, EventArgs e)
        {
            itemsArr[empty] = new Kinly();
            try
            {
                empty++;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("The array is full");
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            string print = "";
            int ind = 0;
            for (int i = 0; i < empty; i++)
            {
                ind = i + 1;
                if (i == empty - 1)
                {
                    print += "Item " + ind + ":" + itemsArr[i].GetPrice();
                }
                else
                {
                    print += "Item " + ind + ":" + itemsArr[i].GetPrice() + ", ";
                }

            }
            MessageBox.Show("Prices are: " + print  + "\n");
        }
    }
}
