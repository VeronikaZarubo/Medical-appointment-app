using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
    }
}
