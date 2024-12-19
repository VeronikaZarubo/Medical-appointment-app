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
    public partial class Menu : Form
    {
        private string name;
        private string surname;
        private string login;
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
            //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            //                                                  + Application.StartupPath + @"\Baza_edytowana.accdb");
            //if (tb_search.Text != "")
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
    }
}
