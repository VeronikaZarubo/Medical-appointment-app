using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    internal class AccessDb_Connection
    {
        public static OleDbConnection con = new OleDbConnection();
        public static OleDbCommand cmd = new OleDbCommand("", con);
        public static OleDbDataAdapter rd;

        public static string currentLogin;
        public static string sql;

        public static string getConnectionString()
        {
            //Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Documents\Documents\Studia\3\Inżynieria programowania\szptal_Windows Forms\WindowsFormsApp1\Baza_edytowana.accdb";Persist Security Info=True
            string connectionString = "Provider = Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Application.StartupPath + "\\Baza_edytowana.accdb;";

            return connectionString;
        }
        public static void OpenConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = getConnectionString();
                    con.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The system failed to establish a connection." + Environment.NewLine + "Descriptions:" + ex.Message.ToString());
            }

        }
        public static void closeConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The system failed to establish a connection 2." + Environment.NewLine + "Descriptions:" + ex.Message.ToString());
            }
        }
    }
}
