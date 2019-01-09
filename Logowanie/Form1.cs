using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Logowanie
{

    public partial class Form1 : Form
    {
        string imie;
        string nazwisko;
        string ident;
        string miasto;
        string[] miasta;
        string formatka;
        string zapis;
        string enter;
        public Form1()
        {
            InitializeComponent();
            miasta = new string[] { "Warszawa", "Poznan", "Krakow", "Gdansk", "Gdynia", "Sosnowiec", "Szczecin", "Olsztyn", "Elblag", "Katowice", "Wroclaw", "Kielce", "Torun", "Leszno", "Zielona Gora", "Lodz", "Opole" };
           for (int i = 0; i < 17; i++)
            {
                comboBox1.Items.Add(miasta[i]);

            }
           
            
            

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            imie = textBox1.Text;
            nazwisko = textBox2.Text;
            miasto = comboBox1.SelectedItem.ToString();
            DateTime data = dateTimePicker1.Value;
            string miesiac = data.Month.ToString();
            string dzien= data.Day.ToString();
            if (miesiac.Length != 2)
            {
                miesiac = "0" + data.Month.ToString();
            }
            if (dzien.Length != 2)
            {
                dzien = "0" + data.Day.ToString();
            }
            
            ident = data.Year.ToString() + miesiac + dzien + rnd.Next(0000000, 999999);
            enter = Environment.NewLine;
            formatka = "Imie: " + imie + " Nazwisko: " + nazwisko + " Miasto: " + miasto + " PESEL: " + ident+enter;

            zapis = formatka;
            
            MessageBox.Show(formatka);

            File.AppendAllText("Lista.txt", zapis);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
