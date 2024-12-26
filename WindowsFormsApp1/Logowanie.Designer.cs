namespace WindowsFormsApp1
{
    partial class Logowanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            this.bt_switchToRegistation = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_passLogin = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label_passLog = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.checkBox_passMask = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_switchToRegistation
            // 
            this.bt_switchToRegistation.BackColor = System.Drawing.Color.Gainsboro;
            this.bt_switchToRegistation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_switchToRegistation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bt_switchToRegistation.Location = new System.Drawing.Point(681, 457);
            this.bt_switchToRegistation.Name = "bt_switchToRegistation";
            this.bt_switchToRegistation.Size = new System.Drawing.Size(284, 58);
            this.bt_switchToRegistation.TabIndex = 12;
            this.bt_switchToRegistation.Text = "Jeszcze nie masz konta? \r\nZarejestruj się!";
            this.bt_switchToRegistation.UseVisualStyleBackColor = false;
            this.bt_switchToRegistation.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(760, 393);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(163, 47);
            this.bt_login.TabIndex = 11;
            this.bt_login.Text = "Zaloguj się";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_switchToRegistation_Click);
            // 
            // tb_passLogin
            // 
            this.tb_passLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tb_passLogin.Location = new System.Drawing.Point(760, 338);
            this.tb_passLogin.Name = "tb_passLogin";
            this.tb_passLogin.Size = new System.Drawing.Size(163, 30);
            this.tb_passLogin.TabIndex = 10;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tb_login.Location = new System.Drawing.Point(760, 282);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(163, 30);
            this.tb_login.TabIndex = 9;
            this.tb_login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_passLog
            // 
            this.label_passLog.AutoSize = true;
            this.label_passLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passLog.Location = new System.Drawing.Point(650, 338);
            this.label_passLog.Name = "label_passLog";
            this.label_passLog.Size = new System.Drawing.Size(83, 20);
            this.label_passLog.TabIndex = 8;
            this.label_passLog.Text = "Password";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(650, 282);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(50, 20);
            this.label_login.TabIndex = 7;
            this.label_login.Text = "Login";
            // 
            // checkBox_passMask
            // 
            this.checkBox_passMask.AutoSize = true;
            this.checkBox_passMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_passMask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_passMask.Location = new System.Drawing.Point(939, 340);
            this.checkBox_passMask.Name = "checkBox_passMask";
            this.checkBox_passMask.Size = new System.Drawing.Size(55, 29);
            this.checkBox_passMask.TabIndex = 13;
            this.checkBox_passMask.Text = "👁\r\n";
            this.checkBox_passMask.UseVisualStyleBackColor = true;
            this.checkBox_passMask.CheckedChanged += new System.EventHandler(this.checkBox_passMask_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(950, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "👁";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Logowanie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_passMask);
            this.Controls.Add(this.bt_switchToRegistation);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_passLogin);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label_passLog);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_switchToRegistation;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_passLogin;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label_passLog;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.CheckBox checkBox_passMask;
        private System.Windows.Forms.Button button1;
    }
}