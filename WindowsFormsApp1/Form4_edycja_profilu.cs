using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4_edycja_profilu : Form
    {
        public string UpdatedName { get; private set; }
        public string UpdatedSurname { get; private set; }
        public string UpdatedEmail { get; private set; }
        public Form4_edycja_profilu(string currentName, string currentSurname, string currentEmail)
        {
            InitializeComponent();
            textBox1_imie.Text = currentName;
            textBox_nazwisko.Text = currentSurname;
            textBox_email.Text = currentEmail;
        }

      
        private void button1_zapiszDane_Click(object sender, EventArgs e)
        {
            UpdatedName = textBox1_imie.Text;
            UpdatedSurname = textBox_nazwisko.Text;
            UpdatedEmail = textBox_email.Text;

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Dane zostały pomyślnie zaktualizowane!");
            this.Close();
        }

        private void button2_anulujDane_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            MessageBox.Show("Dane zostały nie zmienione!");

        }
    }
}
