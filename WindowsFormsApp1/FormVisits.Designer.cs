﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormVisits : Form
    {
        private ListBox listBoxScheduledVisits;
        private ListBox listBoxHistoryVisits;
        private Button buttonHome;

        private Label labelScheduled;
        private Label labelHistory;

   

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listBoxScheduledVisits = new System.Windows.Forms.ListBox();
            this.listBoxHistoryVisits = new System.Windows.Forms.ListBox();
            this.labelScheduled = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxScheduledVisits
            // 
            this.listBoxScheduledVisits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxScheduledVisits.FormattingEnabled = true;
            this.listBoxScheduledVisits.ItemHeight = 16;
            this.listBoxScheduledVisits.Location = new System.Drawing.Point(50, 100);
            this.listBoxScheduledVisits.Name = "listBoxScheduledVisits";
            this.listBoxScheduledVisits.Size = new System.Drawing.Size(300, 292);
            this.listBoxScheduledVisits.TabIndex = 0;
            // 
            // listBoxHistoryVisits
            // 
            this.listBoxHistoryVisits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxHistoryVisits.FormattingEnabled = true;
            this.listBoxHistoryVisits.ItemHeight = 16;
            this.listBoxHistoryVisits.Location = new System.Drawing.Point(400, 100);
            this.listBoxHistoryVisits.Name = "listBoxHistoryVisits";
            this.listBoxHistoryVisits.Size = new System.Drawing.Size(300, 292);
            this.listBoxHistoryVisits.TabIndex = 1;
            // 
            // labelScheduled
            // 
            this.labelScheduled.AutoSize = true;
            this.labelScheduled.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelScheduled.Location = new System.Drawing.Point(50, 50);
            this.labelScheduled.Name = "labelScheduled";
            this.labelScheduled.Size = new System.Drawing.Size(214, 29);
            this.labelScheduled.TabIndex = 2;
            this.labelScheduled.Text = "Zaplanowane wizyty";
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelHistory.Location = new System.Drawing.Point(400, 50);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(168, 29);
            this.labelHistory.TabIndex = 3;
            this.labelHistory.Text = "Historia wizyt";
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonHome.Location = new System.Drawing.Point(750, 20);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(100, 40);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.Text = "🏠";
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // FormVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.listBoxScheduledVisits);
            this.Controls.Add(this.listBoxHistoryVisits);
            this.Controls.Add(this.labelScheduled);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.buttonHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormVisits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia wizyt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            this.Hide();
            loginForm.Show();
        }

        private void LoadVisitsFromDatabase()
        {
            string connectionString = "Ваш_строка_подключения_к_БД";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryScheduled = "SELECT VisitDateTime, PatientName, DoctorName FROM Visits WHERE VisitType = 'Scheduled'";
                    string queryHistory = "SELECT VisitDateTime, PatientName, DoctorName FROM Visits WHERE VisitType = 'History'";

                    using (SqlCommand command = new SqlCommand(queryScheduled, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string visit = $"{reader.GetDateTime(0):HH:mm - dd.MM.yyyy} - {reader.GetString(1)} - {reader.GetString(2)}";
                            listBoxScheduledVisits.Items.Add(visit);
                        }
                    }

                    using (SqlCommand command = new SqlCommand(queryHistory, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string visit = $"{reader.GetDateTime(0):HH:mm - dd.MM.yyyy} - {reader.GetString(1)} - {reader.GetString(2)}";
                            listBoxHistoryVisits.Items.Add(visit);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error data download: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
