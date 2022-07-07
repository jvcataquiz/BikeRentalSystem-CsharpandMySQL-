namespace BikeRentalSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelAside = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.tabControlDashboard = new System.Windows.Forms.TabControl();
            this.tabPageRegistration = new System.Windows.Forms.TabPage();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxRefid = new System.Windows.Forms.TextBox();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelRefId = new System.Windows.Forms.Label();
            this.labelIDtype = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.tabPageBorrow = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.buttonConfrim = new System.Windows.Forms.Button();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.textBoxBikeID = new System.Windows.Forms.TextBox();
            this.textBoxSelected = new System.Windows.Forms.TextBox();
            this.labelCustomerBikeNumber = new System.Windows.Forms.Label();
            this.labelCustomerBikeSelected = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPowerOff = new System.Windows.Forms.Button();
            this.comboBoxIDtype = new System.Windows.Forms.ComboBox();
            this.panelAside.SuspendLayout();
            this.tabControlDashboard.SuspendLayout();
            this.tabPageRegistration.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.tabPageBorrow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAside
            // 
            this.panelAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.panelAside.Controls.Add(this.buttonReturn);
            this.panelAside.Controls.Add(this.buttonBorrow);
            this.panelAside.Controls.Add(this.buttonRegistration);
            this.panelAside.Location = new System.Drawing.Point(12, 121);
            this.panelAside.Name = "panelAside";
            this.panelAside.Size = new System.Drawing.Size(200, 378);
            this.panelAside.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.buttonReturn.Location = new System.Drawing.Point(3, 267);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(194, 50);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.btnDashboard);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.buttonBorrow.FlatAppearance.BorderSize = 0;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.buttonBorrow.Location = new System.Drawing.Point(3, 174);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(194, 50);
            this.buttonBorrow.TabIndex = 1;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.btnDashboard);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.Gray;
            this.buttonRegistration.FlatAppearance.BorderSize = 0;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.buttonRegistration.Location = new System.Drawing.Point(3, 78);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(194, 50);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.btnDashboard);
            // 
            // tabControlDashboard
            // 
            this.tabControlDashboard.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlDashboard.Controls.Add(this.tabPageRegistration);
            this.tabControlDashboard.Controls.Add(this.tabPageBorrow);
            this.tabControlDashboard.Location = new System.Drawing.Point(218, 97);
            this.tabControlDashboard.Name = "tabControlDashboard";
            this.tabControlDashboard.SelectedIndex = 0;
            this.tabControlDashboard.Size = new System.Drawing.Size(570, 406);
            this.tabControlDashboard.TabIndex = 2;
            this.tabControlDashboard.TabStop = false;
            // 
            // tabPageRegistration
            // 
            this.tabPageRegistration.Controls.Add(this.panelDashboard);
            this.tabPageRegistration.Location = new System.Drawing.Point(4, 25);
            this.tabPageRegistration.Name = "tabPageRegistration";
            this.tabPageRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistration.Size = new System.Drawing.Size(562, 377);
            this.tabPageRegistration.TabIndex = 0;
            this.tabPageRegistration.Text = "Registration";
            this.tabPageRegistration.UseVisualStyleBackColor = true;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDashboard.Controls.Add(this.comboBoxIDtype);
            this.panelDashboard.Controls.Add(this.textBoxPhoneNumber);
            this.panelDashboard.Controls.Add(this.textBoxRefid);
            this.panelDashboard.Controls.Add(this.richTextBoxAddress);
            this.panelDashboard.Controls.Add(this.textBoxEmail);
            this.panelDashboard.Controls.Add(this.textBoxFullname);
            this.panelDashboard.Controls.Add(this.labelPhoneNumber);
            this.panelDashboard.Controls.Add(this.labelRefId);
            this.panelDashboard.Controls.Add(this.labelIDtype);
            this.panelDashboard.Controls.Add(this.labelEmail);
            this.panelDashboard.Controls.Add(this.labelAddress);
            this.panelDashboard.Controls.Add(this.labelFullname);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(3, 3);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(556, 371);
            this.panelDashboard.TabIndex = 16;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(30, 292);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(228, 20);
            this.textBoxPhoneNumber.TabIndex = 13;
            // 
            // textBoxRefid
            // 
            this.textBoxRefid.Location = new System.Drawing.Point(289, 221);
            this.textBoxRefid.Name = "textBoxRefid";
            this.textBoxRefid.Size = new System.Drawing.Size(228, 20);
            this.textBoxRefid.TabIndex = 12;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(30, 147);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(487, 35);
            this.richTextBoxAddress.TabIndex = 11;
            this.richTextBoxAddress.Text = "";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(289, 80);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(228, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Location = new System.Drawing.Point(30, 80);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(228, 20);
            this.textBoxFullname.TabIndex = 7;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.labelPhoneNumber.Location = new System.Drawing.Point(13, 265);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(140, 24);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelRefId
            // 
            this.labelRefId.AutoSize = true;
            this.labelRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefId.ForeColor = System.Drawing.Color.White;
            this.labelRefId.Location = new System.Drawing.Point(285, 195);
            this.labelRefId.Name = "labelRefId";
            this.labelRefId.Size = new System.Drawing.Size(58, 24);
            this.labelRefId.TabIndex = 5;
            this.labelRefId.Text = "Ref Id";
            // 
            // labelIDtype
            // 
            this.labelIDtype.AutoSize = true;
            this.labelIDtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDtype.ForeColor = System.Drawing.Color.White;
            this.labelIDtype.Location = new System.Drawing.Point(13, 194);
            this.labelIDtype.Name = "labelIDtype";
            this.labelIDtype.Size = new System.Drawing.Size(75, 24);
            this.labelIDtype.TabIndex = 4;
            this.labelIDtype.Text = "ID Type";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(285, 53);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 24);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(13, 120);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 24);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.ForeColor = System.Drawing.Color.White;
            this.labelFullname.Location = new System.Drawing.Point(13, 53);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(94, 24);
            this.labelFullname.TabIndex = 1;
            this.labelFullname.Text = "Fullname:";
            // 
            // tabPageBorrow
            // 
            this.tabPageBorrow.Controls.Add(this.panel1);
            this.tabPageBorrow.Location = new System.Drawing.Point(4, 25);
            this.tabPageBorrow.Name = "tabPageBorrow";
            this.tabPageBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBorrow.Size = new System.Drawing.Size(562, 377);
            this.tabPageBorrow.TabIndex = 1;
            this.tabPageBorrow.Text = "Borrow";
            this.tabPageBorrow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panelPayment);
            this.panel1.Controls.Add(this.labelCustomerName);
            this.panel1.Controls.Add(this.pictureBoxCamera);
            this.panel1.Controls.Add(this.textBoxBikeID);
            this.panel1.Controls.Add(this.textBoxSelected);
            this.panel1.Controls.Add(this.labelCustomerBikeNumber);
            this.panel1.Controls.Add(this.labelCustomerBikeSelected);
            this.panel1.Controls.Add(this.labelImage);
            this.panel1.Controls.Add(this.labelInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 371);
            this.panel1.TabIndex = 17;
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.buttonConfrim);
            this.panelPayment.Controls.Add(this.labelPayment);
            this.panelPayment.Controls.Add(this.labelMin);
            this.panelPayment.Controls.Add(this.labelHours);
            this.panelPayment.Enabled = false;
            this.panelPayment.Location = new System.Drawing.Point(20, 236);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(525, 132);
            this.panelPayment.TabIndex = 16;
            // 
            // buttonConfrim
            // 
            this.buttonConfrim.Location = new System.Drawing.Point(458, 102);
            this.buttonConfrim.Name = "buttonConfrim";
            this.buttonConfrim.Size = new System.Drawing.Size(64, 27);
            this.buttonConfrim.TabIndex = 20;
            this.buttonConfrim.Text = "Confirm";
            this.buttonConfrim.UseVisualStyleBackColor = true;
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.ForeColor = System.Drawing.Color.White;
            this.labelPayment.Location = new System.Drawing.Point(393, 10);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(83, 24);
            this.labelPayment.TabIndex = 19;
            this.labelPayment.Text = "Payment";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.Color.White;
            this.labelMin.Location = new System.Drawing.Point(134, 10);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(41, 24);
            this.labelMin.TabIndex = 18;
            this.labelMin.Text = "Min";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.ForeColor = System.Drawing.Color.White;
            this.labelHours.Location = new System.Drawing.Point(25, 10);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(61, 24);
            this.labelHours.TabIndex = 17;
            this.labelHours.Text = "Hours";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.ForeColor = System.Drawing.Color.White;
            this.labelCustomerName.Location = new System.Drawing.Point(45, 60);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(160, 24);
            this.labelCustomerName.TabIndex = 15;
            this.labelCustomerName.Text = "Customer\'s Name";
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BackColor = System.Drawing.Color.White;
            this.pictureBoxCamera.Location = new System.Drawing.Point(358, 44);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(165, 147);
            this.pictureBoxCamera.TabIndex = 14;
            this.pictureBoxCamera.TabStop = false;
            // 
            // textBoxBikeID
            // 
            this.textBoxBikeID.Location = new System.Drawing.Point(49, 192);
            this.textBoxBikeID.Name = "textBoxBikeID";
            this.textBoxBikeID.ReadOnly = true;
            this.textBoxBikeID.Size = new System.Drawing.Size(218, 20);
            this.textBoxBikeID.TabIndex = 12;
            // 
            // textBoxSelected
            // 
            this.textBoxSelected.Location = new System.Drawing.Point(47, 133);
            this.textBoxSelected.Name = "textBoxSelected";
            this.textBoxSelected.ReadOnly = true;
            this.textBoxSelected.Size = new System.Drawing.Size(220, 20);
            this.textBoxSelected.TabIndex = 10;
            // 
            // labelCustomerBikeNumber
            // 
            this.labelCustomerBikeNumber.AutoSize = true;
            this.labelCustomerBikeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerBikeNumber.ForeColor = System.Drawing.Color.White;
            this.labelCustomerBikeNumber.Location = new System.Drawing.Point(26, 161);
            this.labelCustomerBikeNumber.Name = "labelCustomerBikeNumber";
            this.labelCustomerBikeNumber.Size = new System.Drawing.Size(125, 24);
            this.labelCustomerBikeNumber.TabIndex = 5;
            this.labelCustomerBikeNumber.Text = "Bike Number:";
            // 
            // labelCustomerBikeSelected
            // 
            this.labelCustomerBikeSelected.AutoSize = true;
            this.labelCustomerBikeSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerBikeSelected.ForeColor = System.Drawing.Color.White;
            this.labelCustomerBikeSelected.Location = new System.Drawing.Point(26, 100);
            this.labelCustomerBikeSelected.Name = "labelCustomerBikeSelected";
            this.labelCustomerBikeSelected.Size = new System.Drawing.Size(229, 24);
            this.labelCustomerBikeSelected.TabIndex = 4;
            this.labelCustomerBikeSelected.Text = "Customer\'s Bike Selected:";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.ForeColor = System.Drawing.Color.White;
            this.labelImage.Location = new System.Drawing.Point(401, 17);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(76, 24);
            this.labelImage.TabIndex = 3;
            this.labelImage.Text = "Camera";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.ForeColor = System.Drawing.Color.White;
            this.labelInformation.Location = new System.Drawing.Point(26, 17);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(206, 24);
            this.labelInformation.TabIndex = 1;
            this.labelInformation.Text = "Customer\'s Information:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.buttonPowerOff);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 79);
            this.panel2.TabIndex = 3;
            // 
            // buttonPowerOff
            // 
            this.buttonPowerOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPowerOff.BackgroundImage")));
            this.buttonPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPowerOff.FlatAppearance.BorderSize = 0;
            this.buttonPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowerOff.Location = new System.Drawing.Point(736, 3);
            this.buttonPowerOff.Name = "buttonPowerOff";
            this.buttonPowerOff.Size = new System.Drawing.Size(37, 34);
            this.buttonPowerOff.TabIndex = 4;
            this.buttonPowerOff.UseVisualStyleBackColor = true;
            this.buttonPowerOff.Click += new System.EventHandler(this.buttonPowerOff_Click);
            // 
            // comboBoxIDtype
            // 
            this.comboBoxIDtype.FormattingEnabled = true;
            this.comboBoxIDtype.Items.AddRange(new object[] {
            "",
            "Student ID",
            "Driver License",
            "National ID",
            "Brgy ID",
            "Postal ID",
            "Other"});
            this.comboBoxIDtype.Location = new System.Drawing.Point(34, 221);
            this.comboBoxIDtype.Name = "comboBoxIDtype";
            this.comboBoxIDtype.Size = new System.Drawing.Size(224, 21);
            this.comboBoxIDtype.TabIndex = 14;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelAside.ResumeLayout(false);
            this.tabControlDashboard.ResumeLayout(false);
            this.tabPageRegistration.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.tabPageBorrow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAside;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TabControl tabControlDashboard;
        private System.Windows.Forms.TabPage tabPageRegistration;
        private System.Windows.Forms.TabPage tabPageBorrow;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxRefid;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelRefId;
        private System.Windows.Forms.Label labelIDtype;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.TextBox textBoxBikeID;
        private System.Windows.Forms.TextBox textBoxSelected;
        private System.Windows.Forms.Label labelCustomerBikeNumber;
        private System.Windows.Forms.Label labelCustomerBikeSelected;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPowerOff;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button buttonConfrim;
        private System.Windows.Forms.ComboBox comboBoxIDtype;
    }
}