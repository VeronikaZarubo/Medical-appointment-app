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
    public partial class lista_lekar : Form
    {
        public lista_lekar()
        {
            InitializeComponent();
        }

        private void lekarzBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lekarzBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza_danych_nowaDataSet);

        }

        private void lista_lekar_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'baza_danych_nowaDataSet.Lekarz' . Możesz go przenieść lub usunąć.
            this.lekarzTableAdapter.Fill(this.baza_danych_nowaDataSet.Lekarz);
            lekarzDataGridView.Columns["dodatkoweInformacje"].Visible = false;
            lekarzDataGridView.Columns["cennikUsług"].Visible = false;

        }

        private void lekarzDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lekarzDataGridView.CurrentRow != null)
            {
                var selectedrow = lekarzDataGridView.CurrentRow;
                string imięLekarza = selectedrow.Cells["imięLekarza"].Value.ToString();
                string nazwiskoLekarza = selectedrow.Cells["nazwiskoLekarza"].Value.ToString();
                int wiek = Convert.ToInt32(selectedrow.Cells["Wiek"].Value);
                string specjalizacja = selectedrow.Cells["Specjalizacja"].Value.ToString();
                string cennikUsług = selectedrow.Cells["cennikUsług"].Value.ToString();

                string dodatkoweinformacje = selectedrow.Cells["Dodatkoweinformacje"].Value.ToString();


                dod_info detailsForm = new dod_info();
                detailsForm.SetDoctorDetails(imięLekarza, nazwiskoLekarza, wiek, specjalizacja, dodatkoweinformacje, cennikUsług);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wybierz lekarza", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
