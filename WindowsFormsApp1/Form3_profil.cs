using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3_profil : Form
    {
        // Переменные для хранения данных профиля
        private string name;
        private string surname;
        private string login;
        public Form3_profil(string name, string surname, string login)
        {
            InitializeComponent();

            // Сохраняем переданные данные в локальные переменные
            name = name;
            surname = surname;
            login = login;

            // Инициализация UI с данными пользователя
            DisplayUserProfile();
        }
        private void DisplayUserProfile()
        {
            textBox1_imie.Text = name;
            textBox_nazwisko.Text = surname;
            textBox_email.Text = login;

            // Отключаем редактирование полей
            textBox1_imie.ReadOnly = true;
            textBox_nazwisko.ReadOnly = true;
            textBox_email.ReadOnly = true;
            // SetReadOnly(true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Открываем окно редактирования
            Form4_edycja_profilu Form4_edycja_Profilu = new Form4_edycja_profilu(name, surname, login);
            // Если пользователь нажал "Сохранить", обновляем данные
            if (Form4_edycja_Profilu.ShowDialog() == DialogResult.OK)
            {
                name = Form4_edycja_Profilu.UpdatedName;
                surname = Form4_edycja_Profilu.UpdatedSurname;
                login = Form4_edycja_Profilu.UpdatedEmail;

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
