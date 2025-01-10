using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System;

namespace WindowsFormsApp1
{
    public partial class FormVisits : Form
    {
        public FormVisits()
        {
            InitializeComponent();
            LoadVisitsFromDatabase();
        }

        private void LoadVisitsFromDatabase()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string queryScheduled = @"
                    SELECT [Data wizyty], 
                           [Lekarz].[Imię lekarza] 
                    FROM [Wizyta] 
                    INNER JOIN [Lekarz] ON [Wizyta].[Lekarz] = [Lekarz].[Identyfikator lekarza]
                    WHERE [Data wizyty] >= Date()";

                using (OleDbCommand command = new OleDbCommand(queryScheduled, connection))
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        string dateTime = reader.IsDBNull(0) ? "Brak daty" : reader.GetDateTime(0).ToString("dd.MM.yyyy HH:mm");
                        string doctor = reader.IsDBNull(1) ? "Brak lekarza" : reader.GetString(1);

                        string visit = $"{dateTime} - {doctor}";
                        listBoxScheduledVisits.Items.Add(visit);
                    }
                }
                
                string queryHistory = @"
                    SELECT [Data wizyty], 
                           [Lekarz].[Imię lekarza] 
                    FROM [Wizyta] 
                    INNER JOIN [Lekarz] ON [Wizyta].[Lekarz] = [Lekarz].[Identyfikator lekarza]
                    WHERE [Data wizyty] < Date()";

                using (OleDbCommand command = new OleDbCommand(queryHistory, connection))
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       
                        string dateTime = reader.IsDBNull(0) ? "Brak daty" : reader.GetDateTime(0).ToString("dd.MM.yyyy HH:mm");
                        string doctor = reader.IsDBNull(1) ? "Brak lekarza" : reader.GetString(1);

                        string visit = $"{dateTime} - {doctor}";
                        listBoxHistoryVisits.Items.Add(visit);
                    }
                }
            }
        }



        private void buttonHome_Click(object sender, EventArgs e)
        {
            Menu loginForm = new Menu();
            this.Hide();
            loginForm.Show();
        }

        private void listBoxScheduledVisits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxScheduledVisits.SelectedItem != null)
            {
                string selectedVisit = listBoxScheduledVisits.SelectedItem.ToString();
                ShowVisitDetails(selectedVisit); 
            }
        }

        private void listBoxHistoryVisits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHistoryVisits.SelectedItem != null)
            {
                string selectedVisit = listBoxHistoryVisits.SelectedItem.ToString();
                ShowVisitDetails(selectedVisit);
            }
        }

        private void ShowVisitDetails(string visitInfo)
        {
            string[] visitDetails = visitInfo.Split('-');
            if (visitDetails.Length >= 3)
            {
                string visitDate = visitDetails[0].Trim();
                string patient = visitDetails[1].Trim();
                string doctor = visitDetails[2].Trim();

                MessageBox.Show($"Data wizyty: {visitDate}\nPacjent: {patient}\nLekarz: {doctor}",
                    "Szczegóły wizyty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie można odczytać danych wizyty.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

// Zakomentowany kod na wypadek, gdybyśmy organizowali zapisy wizyt w bazie danych;
// pobiera on adres e-mail użytkownika aktualnie korzystającego z aplikacji i wyszukuje go w bazie.

/*


private string userName;
private string userSurname;
private string userEmail;

private OleDbConnection connection;

public FormVisits(string email)
{
    InitializeComponent();

    string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Baza danych nowa.accdb;";
    connection = new OleDbConnection(connectString);

    try
    {
        connection.Open(); 

        userEmail = email; 
        GetUserDetailsFromDatabase(userEmail); 
        LoadVisitsFromDatabase(userEmail); 
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        connection.Close();
    }
}

private void GetUserDetailsFromDatabase(string email)
{
    string query = "SELECT [Imię pacjenta], [Nazwisko pacjenta] FROM [Pacjent] WHERE [Email] = ?";
    using (OleDbCommand command = new OleDbCommand(query, connection))
    {
        command.Parameters.Clear();
        command.Parameters.AddWithValue("?", email); 

        using (OleDbDataReader reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                userName = reader.GetString(0);
                userSurname = reader.GetString(1);
            }
            else
            {
                throw new Exception("Пользователь с указанным Email не найден.");
            }
        }
    }
}


private void LoadVisitsFromDatabase(string email)
{
    try
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            MessageBox.Show("Email пользователя не указан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }


        listBoxScheduledVisits.Items.Clear();
        listBoxHistoryVisits.Items.Clear();

        connection.Open();


        string queryScheduled = @"
    SELECT [Data wizyty], [Lekarz].[Nazwisko lekarza]
    FROM ([Wizyta] 
    INNER JOIN [Lekarz] ON [Wizyta].[Lekarz] = [Lekarz].[Identyfikator lekarza])
    INNER JOIN [Pacjent] ON [Wizyta].[Pacjent] = [Pacjent].[Identyfikator pacjenta]
    WHERE [Pacjent].[Email] = ? AND [Data wizyty] >= Date()";


        LoadVisits(queryScheduled, listBoxScheduledVisits, email);


        string queryHistory = @"
    SELECT [Data wizyty], [Lekarz].[Nazwisko lekarza]
    FROM ([Wizyta] 
    INNER JOIN [Lekarz] ON [Wizyta].[Lekarz] = [Lekarz].[Identyfikator lekarza])
    INNER JOIN [Pacjent] ON [Wizyta].[Pacjent] = [Pacjent].[Identyfikator pacjenta]
    WHERE [Pacjent].[Email] = ? AND [Data wizyty] < Date()";

        LoadVisits(queryHistory, listBoxHistoryVisits, email);
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        connection.Close();
    }
}


private void LoadVisits(string query, ListBox listBox, string email)
{
    using (OleDbCommand command = new OleDbCommand(query, connection))
    {
        command.Parameters.Clear();
        command.Parameters.AddWithValue("?", email); 

        using (OleDbDataReader reader = command.ExecuteReader())
        {
            if (!reader.HasRows)
            {
                listBox.Items.Add("No records."); 
                return;
            }

            while (reader.Read())
            {
                string dateTime = reader.IsDBNull(0) ? "Brak daty" : reader.GetDateTime(0).ToString("dd.MM.yyyy HH:mm");
                string doctor = reader.IsDBNull(1) ? "Brak lekarza" : reader.GetString(1);

                string visit = $"{dateTime} - {doctor}";
                listBox.Items.Add(visit);
            }
        }
    }
}


private void buttonHome_Click(object sender, EventArgs e)
{
    Menu loginForm = new Menu();
    this.Hide();
    loginForm.Show();
}

private void listBoxScheduledVisits_SelectedIndexChanged(object sender, EventArgs e)
{
    if (listBoxScheduledVisits.SelectedItem != null)
    {
        string selectedVisit = listBoxScheduledVisits.SelectedItem.ToString();
        ShowVisitDetails(selectedVisit);
    }
}

private void listBoxHistoryVisits_SelectedIndexChanged(object sender, EventArgs e)
{
    if (listBoxHistoryVisits.SelectedItem != null)
    {
        string selectedVisit = listBoxHistoryVisits.SelectedItem.ToString();
        ShowVisitDetails(selectedVisit);
    }
}

private void ShowVisitDetails(string visitInfo)
{
    string[] visitDetails = visitInfo.Split('-');
    if (visitDetails.Length >= 2)
    {
        string visitDate = visitDetails[0].Trim();
        string doctor = visitDetails[1].Trim();

        MessageBox.Show($"Data wizyty: {visitDate}\nLekarz: {doctor}",
            "Szczegóły wizyty", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    else
    {
        MessageBox.Show("Nie można odczytać danych wizyty.",
            "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

private void DebugPacjentTable()
{
    string query = "SELECT [Email], [Imię pacjenta], [Nazwisko pacjenta] FROM [Pacjent]";
    using (OleDbCommand command = new OleDbCommand(query, connection))
    {
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            string debugOutput = "Содержимое таблицы Pacjent:\n";
            while (reader.Read())
            {
                debugOutput += $"Email: {reader["Email"]}, Imię: {reader["Imię pacjenta"]}, Nazwisko: {reader["Nazwisko pacjenta"]}\n";
            }
            MessageBox.Show(debugOutput, "Debugging table Pacjent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

private void DebugWizytaTable()
{
    string query = @"
SELECT [Identyfikator wizyty], [Pacjent], [Lekarz], [Data wizyty]
FROM [Wizyta]";

    using (OleDbCommand command = new OleDbCommand(query, connection))
    {
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            string debugOutput = "Table contents Wizyta:\n";
            while (reader.Read())
            {
                string visitId = reader["Identyfikator wizyty"].ToString();
                string patientId = reader["Pacjent"].ToString();
                string doctorId = reader["Lekarz"].ToString();
                string visitDate = reader["Data wizyty"].ToString();

                debugOutput += $"Wizyta ID: {visitId}, Pacjent ID: {patientId}, Lekarz ID: {doctorId}, Data: {visitDate}\n";
            }
            MessageBox.Show(debugOutput, "Debugging table Wizyta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

private void DebugJoinedTables()
{
    string query = @"
SELECT 
    W.[Identyfikator wizyty],
    W.[Data wizyty],
    P.[Email],
    P.[Imię pacjenta],
    P.[Nazwisko pacjenta],
    L.[Nazwisko lekarza]
FROM ([Wizyta] W
INNER JOIN [Pacjent] P ON W.[Pacjent] = P.[Identyfikator pacjenta])
INNER JOIN [Lekarz] L ON W.[Lekarz] = L.[Identyfikator lekarza]";

    using (OleDbCommand command = new OleDbCommand(query, connection))
    {
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            string debugOutput = "Содержимое объединённых таблиц Wizyta, Pacjent, Lekarz:\n";
            while (reader.Read())
            {
                string visitId = reader["Identyfikator wizyty"].ToString();
                string visitDate = reader["Data wizyty"].ToString();
                string email = reader["Email"].ToString();
                string patientName = reader["Imię pacjenta"].ToString();
                string patientSurname = reader["Nazwisko pacjenta"].ToString();
                string doctorSurname = reader["Nazwisko lekarza"].ToString();

                debugOutput += $"Wizyta ID: {visitId}, Data: {visitDate}, Email: {email}, Pacjent: {patientName} {patientSurname}, Lekarz: {doctorSurname}\n";
            }
            MessageBox.Show(debugOutput, "Debugging merged tables", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}




}
}
*/