using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Rejestracja();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newLevel = new Form2();
            this.Hide();
            newLevel.Show();

            string name;
            string surname;
            string login;
            string pass;
            name = textBox1.Text;
            surname = textBox2.Text;
            login = textBox3.Text;
            pass = textBox4.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
                MessageBox.Show("Proszę wypełnić wszystkie komórki");
            else if (login == pass)
            {
                MessageBox.Show("Udana rejestracja");
                Form2 logowanie = new Form2();
                this.Hide();
                logowanie.Show();
            }
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void Rejestracja()
        {
            
        }

        private void OmFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newLevel = new Form2();
            this.Hide();
            newLevel.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
