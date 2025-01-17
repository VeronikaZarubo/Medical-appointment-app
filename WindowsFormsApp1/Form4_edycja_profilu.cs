using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4_edycja_profilu : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";

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
            UpdatedName = textBox1_imie.Text.Trim();
            UpdatedSurname = textBox_nazwisko.Text.Trim();
            UpdatedEmail = textBox_email.Text.Trim();

            if (string.IsNullOrWhiteSpace(UpdatedName) || string.IsNullOrWhiteSpace(UpdatedSurname) || string.IsNullOrWhiteSpace(UpdatedEmail))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Запрос на обновление данных
                    string updateQuery = "UPDATE Pacjent SET [Imię pacjenta] = @Name, [Nazwisko pacjenta] = @Surname, [Email] = @Email WHERE [Email] = @CurrentEmail";

                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", UpdatedName);
                        command.Parameters.AddWithValue("@Surname", UpdatedSurname);
                        command.Parameters.AddWithValue("@Email", UpdatedEmail);
                        command.Parameters.AddWithValue("@CurrentEmail", Dane.Username); // Используем email текущего пользователя как идентификатор

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Обновляем данные в классе Dane
                            Dane.Name = UpdatedName;
                            Dane.Surname = UpdatedSurname;
                            Dane.Username = UpdatedEmail;

                            MessageBox.Show("Dane zostały pomyślnie zaktualizowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Aktualizacja nie powiodła się. Sprawdź poprawność danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void button2_anulujDane_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            MessageBox.Show("Dane zostały nie zmienione!");

        }
    }
}
