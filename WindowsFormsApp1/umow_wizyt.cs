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
    public partial class umow_wizyt : Form
    {
        private string appointmentType;

        private string doctorName;
        public umow_wizyt(string type, string doctor)
        {
            InitializeComponent();
            appointmentType = type;
            doctorName = doctor;
        }

       
        private void umow_wizyt_Load(object sender, EventArgs e)
        {

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(7);

            LoadAvailableTimeSlots();
        }
        private void LoadAvailableTimeSlots()
        {
            listBox1.Items.Clear();
            DateTime currentTime = dateTimePicker1.Value.Date.AddHours(8);

            while (currentTime.Hour < 18)
            {
                listBox1.Items.Add(currentTime.ToString("HH:mm"));
                currentTime = currentTime.AddMinutes(30);
            }
        }

        private void button1_umów_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                string selectedTime = listBox1.SelectedItem.ToString();
                MessageBox.Show($"Twoja {appointmentType} do lekarza {doctorName} na {dateTimePicker1.Value.ToShortDateString()} o {selectedTime}.",
               "Wizyta została podtwierdzona!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wyberz czas na wizytę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dod_info dod_Info = new dod_info();
            this.Hide();
            dod_Info.Show();
        }
    }
}
