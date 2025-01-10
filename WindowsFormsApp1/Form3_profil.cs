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
        public Form3_profil()
        {
            InitializeComponent();

            textBox1_imie.Text = Dane.Name;
            textBox_nazwisko.Text = Dane.Surname;
            textBox_email.Text = Dane.Username;

            // Инициализация UI с данными пользователя
            DisplayUserProfile();
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
