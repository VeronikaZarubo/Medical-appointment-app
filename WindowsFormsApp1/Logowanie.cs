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
using System.Data.SqlClient;
using WindowsFormsApp1;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    public partial class Logowanie : Form
    {
        private OleDbConnection connection;
        public static OleDbDataReader rd;

        public Logowanie()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";
            connection = new OleDbConnection(connectionString);
        }        

        private void bt_switchToRegistation_Click(object sender, EventArgs e)
        {
            string username = tb_login.Text;
            string password = tb_passLogin.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                string query = "SELECT Email, Hasło FROM Pacjent WHERE Email = @username AND Hasło = @password";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@Email", username.Trim().ToString());
                    command.Parameters.AddWithValue("@Hasło", password.Trim().ToString());

                    rd = command.ExecuteReader();

                    if (rd.HasRows)
                    {
                        Menu newLevel = new Menu();
                        this.Hide();
                        newLevel.Show();

                        while (rd.Read())
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                                                

                        username = string.Empty;
                        password = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                rd.Close(); 
                connection.Close();
            }
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            Rejestracja newLevel = new Rejestracja();
            this.Hide();
            newLevel.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void Form2_Load(object sender, EventArgs e)
        { }

        private void checkBox_passMask_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_passMask.CheckState == CheckState.Checked)
                tb_passLogin.UseSystemPasswordChar = true;
            else
                tb_passLogin.UseSystemPasswordChar = false;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (checkBox_passMask.CheckState == CheckState.Checked)
            //    tb_passLogin.UseSystemPasswordChar = true;
            //else
            //    tb_passLogin.UseSystemPasswordChar = false;

            

            //if 
        }
    } 
}
