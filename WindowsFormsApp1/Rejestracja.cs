using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Rejestracja : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych .accdb1_nowa.accdb;";
        private OleDbConnection connection;

        public static OleDbDataReader rd;

        public Rejestracja()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectString);
        }
        
        private void button1_Click(object sender, EventArgs e)
        { 

            string name = textBox1.Text.ToString();
            string surname = textBox2.Text.ToString(); 
            string username = textBox3.Text.ToString();
            string password = textBox4.Text.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                string query = "SELECT Email, Haslo FROM Pacjent WHERE Email = @username AND Haslo = @password";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@Email", username.Trim());
                    command.Parameters.AddWithValue("@Haslo", password.Trim());

                    rd = command.ExecuteReader();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            MessageBox.Show("This username is already occupied. Please choose another or choose login option.", "Registration Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO [Pacjent] ([Nazwisko pacjenta], [Imię pacjenta], [Email], [Hasło]) VALUES(surname, name, username, password)";

                        using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Imię pacjenta", name);
                            insertCommand.Parameters.AddWithValue("@Nazwisko pacjenta", surname);
                            insertCommand.Parameters.AddWithValue("@Email", username.Trim());
                            insertCommand.Parameters.AddWithValue("@Hasło", password.Trim());

                            insertCommand.ExecuteNonQuery();

                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                name = string.Empty;
                surname = string.Empty;
                username = string.Empty;
                password = string.Empty;
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

        private void OmFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logowanie newLevel = new Logowanie();
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
