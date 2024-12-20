namespace WindowsFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_Moj_profil = new System.Windows.Forms.Button();
            this.log_out_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(373, 379);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(249, 22);
            this.tb_search.TabIndex = 0;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(317, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1_Moj_profil
            // 
            this.button1_Moj_profil.BackColor = System.Drawing.Color.AliceBlue;
            this.button1_Moj_profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Moj_profil.Location = new System.Drawing.Point(928, 12);
            this.button1_Moj_profil.Name = "button1_Moj_profil";
            this.button1_Moj_profil.Size = new System.Drawing.Size(132, 47);
            this.button1_Moj_profil.TabIndex = 2;
            this.button1_Moj_profil.Text = "Mój profil";
            this.button1_Moj_profil.UseVisualStyleBackColor = false;
            this.button1_Moj_profil.Click += new System.EventHandler(this.button1_Moj_profil_Click);
            // 
            // log_out_button
            // 
            this.log_out_button.BackColor = System.Drawing.Color.AliceBlue;
            this.log_out_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_button.Location = new System.Drawing.Point(12, 14);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(146, 45);
            this.log_out_button.TabIndex = 3;
            this.log_out_button.Text = "Wyloguj się";
            this.log_out_button.UseVisualStyleBackColor = false;
            this.log_out_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.AliceBlue;
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.MidnightBlue;
            this.search_button.Location = new System.Drawing.Point(646, 369);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(44, 39);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "🔍";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.log_out_button);
            this.Controls.Add(this.button1_Moj_profil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_search);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_Moj_profil;
        private System.Windows.Forms.Button log_out_button;
        private System.Windows.Forms.Button search_button;
    }
}