using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logowanie
{
    public partial class Form1 : Form
    {
        string imie;
        string nazwisko;
        string dataur;

        string[] miasta = {"Warszawa","Poznan","Krakow","Gdansk","Gdynia","Sopot","Szczecin","Olsztyn","Elblag","Katowice","Wroclaw","Kielce","Torun","Leszno","Zielona Gora","Lodz","Opole"};
        public Form1()
        {
            InitializeComponent();
           for(int i = 0; i < 17; i++)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            imie = textBox1.Text;
            nazwisko = textBox2.Text;
        }
    }
}
