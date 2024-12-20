using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // Do obsługi bazy danych Access

namespace WindowsFormsApp1
{
    public partial class FormVisits : Form
    {
        public FormVisits()
        {
            InitializeComponent();
            LoadVisitsFromDatabase(); // Ładowanie danych z bazy danych
        }

        private void LoadVisitsFromDatabase()
        {
            // Połączenie do bazy danych Access
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Baza_edytowana.accdb";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie do zaplanowanych wizyt
                    string queryScheduled = "SELECT Data_wizyty, Pacjent, Lekarz FROM Wizyta WHERE Data_wizyty >= Date()";
                    using (OleDbCommand command = new OleDbCommand(queryScheduled, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string visit = $"{reader.GetDateTime(0):HH:mm - dd.MM.yyyy} - {reader.GetString(1)} - {reader.GetString(2)}";
                            listBoxScheduledVisits.Items.Add(visit); // Dodanie do listy zaplanowanych wizyt
                        }
        }

                    // Zapytanie do historii wizyt
                    string queryHistory = "SELECT Data_wizyty, Pacjent, Lekarz FROM Wizyta WHERE Data_wizyty < Date()";
                    using (OleDbCommand command = new OleDbCommand(queryHistory, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string visit = $"{reader.GetDateTime(0):HH:mm - dd.MM.yyyy} - {reader.GetString(1)} - {reader.GetString(2)}";
                            listBoxHistoryVisits.Items.Add(visit); // Dodanie do listy historii wizyt
                        }
                    }
                }
            }
            catch (Exception ex)
        {
                MessageBox.Show($"Błąd podczas ładowania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            // Powrót do głównej formy (np. logowanie)
            Form2 loginForm = new Form2();
            this.Hide();
            loginForm.Show();
        }
    }
}
