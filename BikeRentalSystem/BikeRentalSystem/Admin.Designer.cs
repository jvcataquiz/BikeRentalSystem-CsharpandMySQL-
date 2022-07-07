namespace BikeRentalSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPowerOff = new System.Windows.Forms.Button();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.panelDisplay.Controls.Add(this.buttonLogin);
            this.panelDisplay.Controls.Add(this.textBoxUsername);
            this.panelDisplay.Controls.Add(this.labelUsername);
            this.panelDisplay.Controls.Add(this.labelPassword);
            this.panelDisplay.Controls.Add(this.labelLogin);
            this.panelDisplay.Controls.Add(this.textBoxPassword);
            this.panelDisplay.Controls.Add(this.pictureBox1);
            this.panelDisplay.Location = new System.Drawing.Point(40, 85);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(542, 361);
            this.panelDisplay.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.BorderSize = 3;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogin.Location = new System.Drawing.Point(335, 250);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(87, 32);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUsername
            // 
            // 
            // 
            // 
            this.textBoxUsername.CustomButton.Image = null;
            this.textBoxUsername.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.textBoxUsername.CustomButton.Name = "";
            this.textBoxUsername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxUsername.CustomButton.TabIndex = 1;
            this.textBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxUsername.CustomButton.UseSelectable = true;
            this.textBoxUsername.CustomButton.Visible = false;
            this.textBoxUsername.Lines = new string[0];
            this.textBoxUsername.Location = new System.Drawing.Point(115, 130);
            this.textBoxUsername.MaxLength = 32767;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.PromptText = "Enter Username";
            this.textBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.SelectionLength = 0;
            this.textBoxUsername.SelectionStart = 0;
            this.textBoxUsername.ShortcutsEnabled = true;
            this.textBoxUsername.Size = new System.Drawing.Size(307, 30);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.UseSelectable = true;
            this.textBoxUsername.WaterMark = "Enter Username";
            this.textBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelUsername.Location = new System.Drawing.Point(111, 106);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(98, 21);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelPassword.Location = new System.Drawing.Point(111, 171);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(95, 21);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelLogin.Location = new System.Drawing.Point(95, 33);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(71, 24);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Log In";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.textBoxPassword.CustomButton.Image = null;
            this.textBoxPassword.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.textBoxPassword.CustomButton.Name = "";
            this.textBoxPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.textBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPassword.CustomButton.TabIndex = 1;
            this.textBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPassword.CustomButton.UseSelectable = true;
            this.textBoxPassword.CustomButton.Visible = false;
            this.textBoxPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBoxPassword.Lines = new string[0];
            this.textBoxPassword.Location = new System.Drawing.Point(115, 195);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PromptText = "Enter Password";
            this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.ShortcutsEnabled = true;
            this.textBoxPassword.Size = new System.Drawing.Size(307, 30);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPassword.UseSelectable = true;
            this.textBoxPassword.WaterMark = "Enter Password";
            this.textBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPowerOff
            // 
            this.buttonPowerOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPowerOff.BackgroundImage")));
            this.buttonPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPowerOff.FlatAppearance.BorderSize = 0;
            this.buttonPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowerOff.Location = new System.Drawing.Point(545, 34);
            this.buttonPowerOff.Name = "buttonPowerOff";
            this.buttonPowerOff.Size = new System.Drawing.Size(37, 34);
            this.buttonPowerOff.TabIndex = 1;
            this.buttonPowerOff.UseVisualStyleBackColor = true;
            this.buttonPowerOff.Click += new System.EventHandler(this.buttonPowerOff_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(625, 485);
            this.Controls.Add(this.buttonPowerOff);
            this.Controls.Add(this.panelDisplay);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private MetroFramework.Controls.MetroTextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonPowerOff;
    }
}

