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
    public partial class umow_wizyt : Form
    {
        private string appointmentType;

        private string doctorName;
        private string username;
        public umow_wizyt(string type, string doctor, string email)
        {
            InitializeComponent();
            appointmentType = type;
            doctorName = doctor;
            username = email;
        }

       
        private void umow_wizyt_Load(object sender, EventArgs e)
        {

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(7);

            LoadAvailableTimeSlots();
        }
        private void LoadAvailableTimeSlots()
        {
            listBox1.Items.Clear();
            DateTime currentTime = dateTimePicker1.Value.Date.AddHours(8);

            while (currentTime.Hour < 18)
            {
                listBox1.Items.Add(currentTime.ToString("HH:mm"));
                currentTime = currentTime.AddMinutes(30);
            }
        }
        private bool IsTimeSlotAvailable(DateTime date, string time, string doctor)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Wizyta WHERE [Lekarz] = @Doctor AND [Data wizyty] = @Date AND [Czas] = @Time";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Doctor", doctor);
                    command.Parameters.AddWithValue("@Date", date.ToShortDateString());
                    command.Parameters.AddWithValue("@Time", time);

                    int count = (int)command.ExecuteScalar();
                    return count == 0;  // Возвращает true, если время доступно
                }
            }
        }
        private void AddAppointment(string patientEmail, string doctor, DateTime date, string time)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Wizyta (Pacjent, Lekarz, [Data wizyty], Czas) VALUES (@Patient, @Doctor, @Date, @Time)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Patient", patientEmail);
                    command.Parameters.AddWithValue("@Doctor", doctor);
                    command.Parameters.AddWithValue("@Date", date.ToShortDateString());
                    command.Parameters.AddWithValue("@Time", time);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_umów_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedTime = listBox1.SelectedItem.ToString();
                DateTime selectedDate = dateTimePicker1.Value;

                if (IsTimeSlotAvailable(selectedDate, selectedTime, doctorName))
                {
                    AddAppointment(username, doctorName, selectedDate, selectedTime);

                    MessageBox.Show($"Twoja {appointmentType} do lekarza {doctorName} na {selectedDate.ToShortDateString()} o {selectedTime}.",
                    "Wizyta została podtwierdzona!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wybrane czas i data są już zajęte, wybierz inny termin.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wyberz czas na wizytę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dod_info dod_Info = new dod_info();
            this.Hide();
            dod_Info.Show();
        }
    }
}
