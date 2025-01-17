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
    public partial class dod_info : Form
    {
        private string doctorName;

        public dod_info()
        {
            InitializeComponent();
        }

        public void SetDoctorDetails(string imięLekarza, string nazwiskoLekarza, int wiek, string specjalizacja, string dodatkoweinformacje, string cennikUsług)
        {
            doctorName = $"{imięLekarza} {nazwiskoLekarza}";
            label2_imie.Text = $"{imięLekarza}";
            label3_nazwisko.Text = $"{nazwiskoLekarza}";
            label4_wiek.Text = $"{wiek}";
            label5_spec.Text = $"{specjalizacja}";
            label6_DODINF.Text = $"{dodatkoweinformacje}";
            label6_cennik.Text = $"{cennikUsług}";

        }
        private void button1_konsul_Click(object sender, EventArgs e)
        {
            Dane.Doctorname = label3_nazwisko.Text;

            umow_wizyt wizytaform = new umow_wizyt("Konsultacja");
            wizytaform.ShowDialog();
        }

        private void button2_wiz_Click(object sender, EventArgs e)
        {
            Dane.Doctorname = label3_nazwisko.Text;

            umow_wizyt wizytaform = new umow_wizyt("Wizyta");
            wizytaform.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista_lekar lista_Lekar = new lista_lekar();
            this.Hide();
            lista_Lekar.Show();
        }
    }
}
