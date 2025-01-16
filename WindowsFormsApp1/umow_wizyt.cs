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

        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";
        private OleDbConnection connection;

        
        public umow_wizyt(string type)
        {
            InitializeComponent();
            appointmentType = type;
            connection = new OleDbConnection(connectionString);


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
            
             

        private void button1_umów_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string selectedTime = listBox1.SelectedItem.ToString();
                string fullDateTime = $"{selectedDate} {selectedTime}";
                try
                {
                    // Открываем соединение с базой данных
                    connection.Open();

                    // SQL-запрос для добавления записи в таблицу Wizyta
                    string query = "INSERT INTO Wizyta ([Pacjent], [Lekarz], [Data wizyty]) VALUES (@Pacjent, @Lekarz, @DataWizyty)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Добавляем параметры
                        command.Parameters.AddWithValue("@Pacjent", Dane.Username); // Электронная почта пациента из класса Dane
                        command.Parameters.AddWithValue("@Lekarz", Dane.Doctorname); // Имя врача
                        command.Parameters.AddWithValue("@DataWizyty", DateTime.Parse(fullDateTime)); // Дата и время визита

                        // Выполняем запрос
                        command.ExecuteNonQuery();
                    }

                    // Уведомляем пользователя
                    MessageBox.Show(
                        $"Twoja {appointmentType} do lekarza {Dane.Doctorname} została zapisana na {selectedDate} o godzinie {selectedTime}.",
                        "Sukces",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
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
