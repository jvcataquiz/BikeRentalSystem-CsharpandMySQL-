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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelAside = new System.Windows.Forms.Panel();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.tabControlDashboard = new System.Windows.Forms.TabControl();
            this.tabPageRegistration = new System.Windows.Forms.TabPage();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.textBoxBikeID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.pictureBoxCameraImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxSelected = new System.Windows.Forms.TextBox();
            this.labelCustomerBikeSelected = new System.Windows.Forms.Label();
            this.buttonBikeSelection = new System.Windows.Forms.Button();
            this.comboBoxIDtype = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxRefid = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelRefId = new System.Windows.Forms.Label();
            this.labelIDtype = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.tabPageBorrow = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.buttonConfrim = new System.Windows.Forms.Button();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonPowerOff = new System.Windows.Forms.Button();
            this.timerCustomerSelection = new System.Windows.Forms.Timer(this.components);
            this.panelAside.SuspendLayout();
            this.tabControlDashboard.SuspendLayout();
            this.tabPageRegistration.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCameraImage)).BeginInit();
            this.tabPageBorrow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAside
            // 
            this.panelAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.panelAside.Controls.Add(this.buttonBorrow);
            this.panelAside.Controls.Add(this.buttonRegistration);
            this.panelAside.Location = new System.Drawing.Point(12, 87);
            this.panelAside.Name = "panelAside";
            this.panelAside.Size = new System.Drawing.Size(200, 432);
            this.panelAside.TabIndex = 1;
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
            this.buttonBorrow.Text = "Confirmation";
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
            this.tabControlDashboard.Location = new System.Drawing.Point(218, 62);
            this.tabControlDashboard.Name = "tabControlDashboard";
            this.tabControlDashboard.SelectedIndex = 0;
            this.tabControlDashboard.Size = new System.Drawing.Size(570, 457);
            this.tabControlDashboard.TabIndex = 2;
            this.tabControlDashboard.TabStop = false;
            // 
            // tabPageRegistration
            // 
            this.tabPageRegistration.Controls.Add(this.panelDashboard);
            this.tabPageRegistration.Location = new System.Drawing.Point(4, 25);
            this.tabPageRegistration.Name = "tabPageRegistration";
            this.tabPageRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistration.Size = new System.Drawing.Size(562, 428);
            this.tabPageRegistration.TabIndex = 0;
            this.tabPageRegistration.Text = "Registration";
            this.tabPageRegistration.UseVisualStyleBackColor = true;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDashboard.Controls.Add(this.textBoxBikeID);
            this.panelDashboard.Controls.Add(this.button2);
            this.panelDashboard.Controls.Add(this.buttonCapture);
            this.panelDashboard.Controls.Add(this.pictureBoxCameraImage);
            this.panelDashboard.Controls.Add(this.label3);
            this.panelDashboard.Controls.Add(this.richTextBoxAddress);
            this.panelDashboard.Controls.Add(this.labelAddress);
            this.panelDashboard.Controls.Add(this.textBoxSelected);
            this.panelDashboard.Controls.Add(this.labelCustomerBikeSelected);
            this.panelDashboard.Controls.Add(this.buttonBikeSelection);
            this.panelDashboard.Controls.Add(this.comboBoxIDtype);
            this.panelDashboard.Controls.Add(this.textBoxPhoneNumber);
            this.panelDashboard.Controls.Add(this.textBoxRefid);
            this.panelDashboard.Controls.Add(this.textBoxEmail);
            this.panelDashboard.Controls.Add(this.textBoxFullname);
            this.panelDashboard.Controls.Add(this.labelPhoneNumber);
            this.panelDashboard.Controls.Add(this.labelRefId);
            this.panelDashboard.Controls.Add(this.labelIDtype);
            this.panelDashboard.Controls.Add(this.labelEmail);
            this.panelDashboard.Controls.Add(this.labelFullname);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(3, 3);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(556, 422);
            this.panelDashboard.TabIndex = 16;
            // 
            // textBoxBikeID
            // 
            this.textBoxBikeID.Location = new System.Drawing.Point(173, 33);
            this.textBoxBikeID.Name = "textBoxBikeID";
            this.textBoxBikeID.ReadOnly = true;
            this.textBoxBikeID.Size = new System.Drawing.Size(123, 20);
            this.textBoxBikeID.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 25);
            this.button2.TabIndex = 23;
            this.button2.Text = "Bike Selection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCapture
            // 
            this.buttonCapture.Location = new System.Drawing.Point(372, 226);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(88, 29);
            this.buttonCapture.TabIndex = 22;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // pictureBoxCameraImage
            // 
            this.pictureBoxCameraImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxCameraImage.Location = new System.Drawing.Point(325, 33);
            this.pictureBoxCameraImage.Name = "pictureBoxCameraImage";
            this.pictureBoxCameraImage.Size = new System.Drawing.Size(200, 187);
            this.pictureBoxCameraImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCameraImage.TabIndex = 21;
            this.pictureBoxCameraImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(384, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Camera";
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(30, 329);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(494, 35);
            this.richTextBoxAddress.TabIndex = 19;
            this.richTextBoxAddress.Text = "";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(20, 302);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 24);
            this.labelAddress.TabIndex = 18;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxSelected
            // 
            this.textBoxSelected.Location = new System.Drawing.Point(30, 33);
            this.textBoxSelected.Name = "textBoxSelected";
            this.textBoxSelected.ReadOnly = true;
            this.textBoxSelected.Size = new System.Drawing.Size(123, 20);
            this.textBoxSelected.TabIndex = 17;
            // 
            // labelCustomerBikeSelected
            // 
            this.labelCustomerBikeSelected.AutoSize = true;
            this.labelCustomerBikeSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerBikeSelected.ForeColor = System.Drawing.Color.White;
            this.labelCustomerBikeSelected.Location = new System.Drawing.Point(3, 0);
            this.labelCustomerBikeSelected.Name = "labelCustomerBikeSelected";
            this.labelCustomerBikeSelected.Size = new System.Drawing.Size(229, 24);
            this.labelCustomerBikeSelected.TabIndex = 16;
            this.labelCustomerBikeSelected.Text = "Customer\'s Bike Selected:";
            // 
            // buttonBikeSelection
            // 
            this.buttonBikeSelection.Location = new System.Drawing.Point(436, 379);
            this.buttonBikeSelection.Name = "buttonBikeSelection";
            this.buttonBikeSelection.Size = new System.Drawing.Size(88, 29);
            this.buttonBikeSelection.TabIndex = 15;
            this.buttonBikeSelection.Text = "Next";
            this.buttonBikeSelection.UseVisualStyleBackColor = true;
            this.buttonBikeSelection.Click += new System.EventHandler(this.buttonBikeSelection_Click);
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
            this.comboBoxIDtype.Location = new System.Drawing.Point(24, 278);
            this.comboBoxIDtype.Name = "comboBoxIDtype";
            this.comboBoxIDtype.Size = new System.Drawing.Size(224, 21);
            this.comboBoxIDtype.TabIndex = 14;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(28, 212);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(228, 20);
            this.textBoxPhoneNumber.TabIndex = 13;
            // 
            // textBoxRefid
            // 
            this.textBoxRefid.Location = new System.Drawing.Point(296, 279);
            this.textBoxRefid.Name = "textBoxRefid";
            this.textBoxRefid.Size = new System.Drawing.Size(228, 20);
            this.textBoxRefid.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(30, 153);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(228, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Location = new System.Drawing.Point(29, 103);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(228, 20);
            this.textBoxFullname.TabIndex = 7;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.labelPhoneNumber.Location = new System.Drawing.Point(13, 185);
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
            this.labelRefId.Location = new System.Drawing.Point(292, 252);
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
            this.labelIDtype.Location = new System.Drawing.Point(20, 245);
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
            this.labelEmail.Location = new System.Drawing.Point(20, 126);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 24);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.ForeColor = System.Drawing.Color.White;
            this.labelFullname.Location = new System.Drawing.Point(13, 66);
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
            this.tabPageBorrow.Size = new System.Drawing.Size(562, 428);
            this.tabPageBorrow.TabIndex = 1;
            this.tabPageBorrow.Text = "Borrow";
            this.tabPageBorrow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelPayment);
            this.panel1.Controls.Add(this.labelCustomerName);
            this.panel1.Controls.Add(this.pictureBoxCamera);
            this.panel1.Controls.Add(this.labelImage);
            this.panel1.Controls.Add(this.labelInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 422);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Customer\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Customer\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer\'s Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Customer\'s Name";
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.textBoxPayment);
            this.panelPayment.Controls.Add(this.numericUpDownHour);
            this.panelPayment.Controls.Add(this.buttonConfrim);
            this.panelPayment.Controls.Add(this.labelPayment);
            this.panelPayment.Controls.Add(this.labelHours);
            this.panelPayment.Enabled = false;
            this.panelPayment.Location = new System.Drawing.Point(3, 259);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(550, 140);
            this.panelPayment.TabIndex = 16;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(345, 46);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(150, 20);
            this.textBoxPayment.TabIndex = 22;
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(29, 46);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(110, 20);
            this.numericUpDownHour.TabIndex = 21;
            this.numericUpDownHour.ValueChanged += new System.EventHandler(this.numericUpDownHour_ValueChanged);
            // 
            // buttonConfrim
            // 
            this.buttonConfrim.Location = new System.Drawing.Point(431, 102);
            this.buttonConfrim.Name = "buttonConfrim";
            this.buttonConfrim.Size = new System.Drawing.Size(64, 27);
            this.buttonConfrim.TabIndex = 20;
            this.buttonConfrim.Text = "Confirm";
            this.buttonConfrim.UseVisualStyleBackColor = true;
            this.buttonConfrim.Click += new System.EventHandler(this.buttonConfrim_Click);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.ForeColor = System.Drawing.Color.White;
            this.labelPayment.Location = new System.Drawing.Point(373, 19);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(83, 24);
            this.labelPayment.TabIndex = 19;
            this.labelPayment.Text = "Payment";
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
            this.pictureBoxCamera.Location = new System.Drawing.Point(334, 44);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(189, 180);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamera.TabIndex = 14;
            this.pictureBoxCamera.TabStop = false;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.ForeColor = System.Drawing.Color.White;
            this.labelImage.Location = new System.Drawing.Point(397, 17);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(62, 24);
            this.labelImage.TabIndex = 3;
            this.labelImage.Text = "Image";
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
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.buttonPowerOff);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 44);
            this.panel2.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(296, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(213, 24);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "BIKE RENTAL SYSTEM";
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
            // timerCustomerSelection
            // 
            this.timerCustomerSelection.Enabled = true;
            this.timerCustomerSelection.Tick += new System.EventHandler(this.timerCustomerSelection_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelAside.ResumeLayout(false);
            this.tabControlDashboard.ResumeLayout(false);
            this.tabPageRegistration.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCameraImage)).EndInit();
            this.tabPageBorrow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAside;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TabControl tabControlDashboard;
        private System.Windows.Forms.TabPage tabPageRegistration;
        private System.Windows.Forms.TabPage tabPageBorrow;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxRefid;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelRefId;
        private System.Windows.Forms.Label labelIDtype;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPowerOff;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button buttonConfrim;
        private System.Windows.Forms.ComboBox comboBoxIDtype;
        private System.Windows.Forms.Timer timerCustomerSelection;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.PictureBox pictureBoxCameraImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxSelected;
        private System.Windows.Forms.Label labelCustomerBikeSelected;
        private System.Windows.Forms.Button buttonBikeSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxBikeID;
    }
}