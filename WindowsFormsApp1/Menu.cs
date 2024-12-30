using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        private string name;
        private string surname;
        private string login;

        private OleDbConnection connection;

        public Menu()
        {
            InitializeComponent();
            string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";
            connection = new OleDbConnection(connectString);
        }   

        private void Menu_Load(object sender, EventArgs e)
        {


        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Moj_profil_Click(object sender, EventArgs e)
        {
            // Передаем данные пользователя в конструктор формы profil
            using (Form3_profil form = new Form3_profil(name, surname, login))
            {
                form.ShowDialog(); // Открываем форму модально
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rejestracja newLevel = new Rejestracja();
            this.Hide();
            newLevel.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string spec = tb_search.Text.ToString();

            try
            {
                if (string.IsNullOrWhiteSpace(spec))
                {
                    MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                connection.Open();

                string query = "SELECT [Imię lekarza],  [Nazwisko lekarza], Specjalizacja FROM Lekarz " +
                    "WHERE [Imię lekarza] LIKE @SearchTerm OR [Nazwisko lekarza] LIKE @SearchTerm OR [Specjalizacja] LIKE @SearchTerm;";


                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Clear();
                                        
                    command.Parameters.AddWithValue("@SearchTerm", "%" + spec + "%");

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
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

        private void tb_search_Enter(object sender, EventArgs e)
        {
            if (tb_search.Text == "Wyszukaj lekarza...")
            {
                tb_search.Text = "";
                tb_search.ForeColor = Color.Black;
            }
        }

        private void tb_search_Leave(object sender, EventArgs e)
        {
            if (tb_search.Text == "")
            {
                tb_search.Text = "Wyszukaj lekarza...";
                tb_search.ForeColor = Color.Silver;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormVisits visitsForm = new FormVisits(/*userEmail*/);
            this.Hide();
            visitsForm.Show();
        }
        private void button2_list_lekar_Click(object sender, EventArgs e)
        {
            lista_lekar lista_Lekar = new lista_lekar();
            this.Hide();
            lista_Lekar.Show();
        }

        private string userEmail;

        /* public Menu(string email) // Zakomentowany kod na wypadek, gdybyśmy organizowali zapisy wizyt w bazie danych;
         {
             InitializeComponent();
             this.userEmail = email; // save email to use in visits
         }*/

    }
}
