namespace WindowsFormsApp1
{
    partial class Rejestracja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rejestracja));
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.bt_createAccount = new System.Windows.Forms.Button();
            this.bt_swichToLogin = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_pass1 = new System.Windows.Forms.Label();
            this.textBox_pass1 = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label_pass2 = new System.Windows.Forms.Label();
            this.textBox_pass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(655, 159);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(40, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Imię";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_surname.Location = new System.Drawing.Point(653, 212);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(81, 20);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Nazwisko";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_surname.Location = new System.Drawing.Point(784, 212);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(183, 30);
            this.textBox_surname.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_name.Location = new System.Drawing.Point(784, 159);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(183, 30);
            this.textBox_name.TabIndex = 3;
            // 
            // bt_createAccount
            // 
            this.bt_createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_createAccount.Location = new System.Drawing.Point(783, 407);
            this.bt_createAccount.Name = "bt_createAccount";
            this.bt_createAccount.Size = new System.Drawing.Size(183, 56);
            this.bt_createAccount.TabIndex = 4;
            this.bt_createAccount.Text = "Utwórz konto";
            this.bt_createAccount.UseVisualStyleBackColor = true;
            this.bt_createAccount.Click += new System.EventHandler(this.bt_createAccount_Click);
            // 
            // bt_swichToLogin
            // 
            this.bt_swichToLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_swichToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_swichToLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bt_swichToLogin.Location = new System.Drawing.Point(683, 469);
            this.bt_swichToLogin.Name = "bt_swichToLogin";
            this.bt_swichToLogin.Size = new System.Drawing.Size(284, 62);
            this.bt_swichToLogin.TabIndex = 13;
            this.bt_swichToLogin.Text = "Już masz konto? \r\nZaloguj się!";
            this.bt_swichToLogin.UseVisualStyleBackColor = false;
            this.bt_swichToLogin.Click += new System.EventHandler(this.bt_swichToLogin_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_email.Location = new System.Drawing.Point(784, 263);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(183, 30);
            this.textBox_email.TabIndex = 15;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(655, 263);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 20);
            this.label_email.TabIndex = 16;
            this.label_email.Text = "Email";
            // 
            // label_pass1
            // 
            this.label_pass1.AutoSize = true;
            this.label_pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass1.Location = new System.Drawing.Point(655, 313);
            this.label_pass1.Name = "label_pass1";
            this.label_pass1.Size = new System.Drawing.Size(53, 20);
            this.label_pass1.TabIndex = 17;
            this.label_pass1.Text = "Hasło";
            // 
            // textBox_pass1
            // 
            this.textBox_pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_pass1.Location = new System.Drawing.Point(784, 313);
            this.textBox_pass1.Name = "textBox_pass1";
            this.textBox_pass1.Size = new System.Drawing.Size(183, 30);
            this.textBox_pass1.TabIndex = 18;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label_pass2
            // 
            this.label_pass2.AutoSize = true;
            this.label_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass2.Location = new System.Drawing.Point(656, 356);
            this.label_pass2.Name = "label_pass2";
            this.label_pass2.Size = new System.Drawing.Size(53, 20);
            this.label_pass2.TabIndex = 19;
            this.label_pass2.Text = "Hasło";
            // 
            // textBox_pass2
            // 
            this.textBox_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass2.Location = new System.Drawing.Point(784, 356);
            this.textBox_pass2.Name = "textBox_pass2";
            this.textBox_pass2.Size = new System.Drawing.Size(183, 30);
            this.textBox_pass2.TabIndex = 20;
            // 
            // Rejestracja
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Rejestracja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.textBox_pass2);
            this.Controls.Add(this.label_pass2);
            this.Controls.Add(this.textBox_pass1);
            this.Controls.Add(this.label_pass1);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.bt_swichToLogin);
            this.Controls.Add(this.bt_createAccount);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rejestracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OmFormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button bt_createAccount;
        private System.Windows.Forms.Button bt_swichToLogin;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_pass1;
        private System.Windows.Forms.TextBox textBox_pass1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label_pass2;
        private System.Windows.Forms.TextBox textBox_pass2;
    }
}

