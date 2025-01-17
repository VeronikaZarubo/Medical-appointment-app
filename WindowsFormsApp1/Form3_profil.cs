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
    public partial class Form3_profil : Form
    {
        private OleDbConnection connection;
        public static OleDbDataReader rd;
        public Form3_profil()
        {
            InitializeComponent();

            
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";
            connection = new OleDbConnection(connectionString);

            // Инициализация UI с данными пользователя
            DisplayUserProfile();
        }
        
        private void Form3_profil_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT [Imię pacjenta], [Nazwisko pacjenta] FROM Pacjent WHERE Email = @Email";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", Dane.Username);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Получаем имя и фамилию из базы данных
                            string name = reader["Imię pacjenta"].ToString();
                            string surname = reader["Nazwisko pacjenta"].ToString();

                            // Отображаем данные на форме
                            textBox1_imie.Text = name;
                            textBox_nazwisko.Text = surname;
                            textBox_email.Text = Dane.Username;
                        }
                        else
                        {
                            MessageBox.Show("User not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();

            }
        }
        private void DisplayUserProfile()
        {
            

            // Отключаем редактирование полей
            textBox1_imie.ReadOnly = true;
            textBox_nazwisko.ReadOnly = true;
            textBox_email.ReadOnly = true;
            // SetReadOnly(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Открываем окно редактирования
            Form4_edycja_profilu Form4_edycja_Profilu = new Form4_edycja_profilu(textBox1_imie.Text, textBox_nazwisko.Text, textBox_email.Text);
            // Если пользователь нажал "Сохранить", обновляем данные
            if (Form4_edycja_Profilu.ShowDialog() == DialogResult.OK)
            {
                textBox1_imie.Text = Form4_edycja_Profilu.UpdatedName;
                textBox_nazwisko.Text = Form4_edycja_Profilu.UpdatedSurname;
                textBox_email.Text = Form4_edycja_Profilu.UpdatedEmail;

                DisplayUserProfile();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

       
    }
}
