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
    public partial class FormVisits : Form
    {
        public FormVisits()
        {
            InitializeComponent();
            LoadVisitsFromDatabase(); 
        }

        private void LoadVisitsFromDatabase()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Baza_edytowana.accdb";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    
                    string queryScheduled = "SELECT Data_wizyty, Pacjent, Lekarz FROM Wizyta WHERE Data_wizyty >= Date()";
                    using (OleDbCommand command = new OleDbCommand(queryScheduled, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string visit = $"{reader.GetDateTime(0):HH:mm - dd.MM.yyyy} - {reader.GetString(1)} - {reader.GetString(2)}";
                            listBoxScheduledVisits.Items.Add(visit); 
                        }
        }

                  
                    string queryHistory = "SELECT Data_wizyty, Pacjent, Lekarz FROM Wizyta WHERE Data_wizyty < Date()";
                    using (OleDbCommand command = new OleDbCommand(queryHistory, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string visit = $"{reader.GetDateTime(0):HH:mm - dd.MM.yyyy} - {reader.GetString(1)} - {reader.GetString(2)}";
                            listBoxHistoryVisits.Items.Add(visit); 
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
            Form2 loginForm = new Form2();
            this.Hide();
            loginForm.Show();
        }
    }
}
