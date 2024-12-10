using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents\Documents\Studia\3\Inżynieria programowania\Baza_edytowana.accdb;Persist Security Info=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = string.Empty;


                connection.Close();
            }
            catch 
            {
                //

            }      

            string login;
            string pass;
            login = textBox1.Text;
            pass = textBox2.Text;

            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Proszę podać login i hasło");
                textBox1.Focus();
            }                

            else if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Proszę podać login");
                textBox1.Focus();
            }
                
            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Proszę podać hasło");
                textBox2.Focus();
            }
            else if (login == pass)
            {
                MessageBox.Show("Udane logowanie");
                Menu newLevel = new Menu();
                this.Hide();
                newLevel.Show();
            }
            else MessageBox.Show("Zły login lub hasło");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newLevel = new Form1();
            this.Hide();
            newLevel.Show();
        }
    }
}
