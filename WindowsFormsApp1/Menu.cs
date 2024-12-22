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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        private string name;
        private string surname;
        private string login;

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";
        private OleDbConnection connection;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {


        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }
        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //oledbconnection connection = new oledbconnection("provider=microsoft.ace.oledb.12.0;data source=baza danych .accdb1_nowa.accdb");
            //if (tb_search.text != "")
            //{


            //}

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
            try
            {
                string spec = tb_search.Text.ToString();

                connection.Open();

                string query = "SELECT * FROM Lekarz WHERE Specjalizacja = @spec;";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@Specjalizacja", spec.Trim());

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

                //spec = string.Empty;
            }
        }
    }
}
