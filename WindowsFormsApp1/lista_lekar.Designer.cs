﻿namespace WindowsFormsApp1
{
    partial class lista_lekar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lista_lekar));
            this.baza_danych_nowaDataSet = new WindowsFormsApp1.Baza_danych_nowaDataSet();
            this.lekarzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lekarzTableAdapter = new WindowsFormsApp1.Baza_danych_nowaDataSetTableAdapters.LekarzTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Baza_danych_nowaDataSetTableAdapters.TableAdapterManager();
            this.lekarzDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza_danych_nowaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // baza_danych_nowaDataSet
            // 
            this.baza_danych_nowaDataSet.DataSetName = "Baza_danych_nowaDataSet";
            this.baza_danych_nowaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lekarzBindingSource
            // 
            this.lekarzBindingSource.DataMember = "Lekarz";
            this.lekarzBindingSource.DataSource = this.baza_danych_nowaDataSet;
            // 
            // lekarzTableAdapter
            // 
            this.lekarzTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LekarzTableAdapter = this.lekarzTableAdapter;
            this.tableAdapterManager.PacjentTableAdapter = null;
            this.tableAdapterManager.SpecjalizacjaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Baza_danych_nowaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WizytaTableAdapter = null;
            // 
            // lekarzDataGridView
            // 
            this.lekarzDataGridView.AutoGenerateColumns = false;
            this.lekarzDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lekarzDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lekarzDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.lekarzDataGridView.DataSource = this.lekarzBindingSource;
            this.lekarzDataGridView.EnableHeadersVisualStyles = false;
            this.lekarzDataGridView.Location = new System.Drawing.Point(55, 56);
            this.lekarzDataGridView.Name = "lekarzDataGridView";
            this.lekarzDataGridView.RowHeadersVisible = false;
            this.lekarzDataGridView.RowHeadersWidth = 51;
            this.lekarzDataGridView.RowTemplate.Height = 24;
            this.lekarzDataGridView.Size = new System.Drawing.Size(861, 364);
            this.lekarzDataGridView.TabIndex = 1;
            this.lekarzDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lekarzDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nazwisko lekarza";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwisko lekarza";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Imię lekarza";
            this.dataGridViewTextBoxColumn3.HeaderText = "Imię lekarza";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Wiek";
            this.dataGridViewTextBoxColumn4.HeaderText = "Wiek";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Specjalizacja";
            this.dataGridViewTextBoxColumn6.HeaderText = "Specjalizacja";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Dodatkowe informacje";
            this.dataGridViewTextBoxColumn7.HeaderText = "Dodatkowe informacje";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cennik usług";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cennik usług";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "NASI LEKARZE";
            // 
            // lista_lekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lekarzDataGridView);
            this.Name = "lista_lekar";
            this.Text = "LISTA LEKARZE";
            this.Load += new System.EventHandler(this.lista_lekar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza_danych_nowaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekarzDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza_danych_nowaDataSet baza_danych_nowaDataSet;
        private System.Windows.Forms.BindingSource lekarzBindingSource;
        private Baza_danych_nowaDataSetTableAdapters.LekarzTableAdapter lekarzTableAdapter;
        private Baza_danych_nowaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lekarzDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label1;
    }
}