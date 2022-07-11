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
            this.panelAside = new System.Windows.Forms.Panel();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.tabControlDashboard = new System.Windows.Forms.TabControl();
            this.tabPageRegistration = new System.Windows.Forms.TabPage();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.buttonOpenCam = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.labeltimeanddate = new System.Windows.Forms.Label();
            this.labelCAdd = new System.Windows.Forms.Label();
            this.labelCRID = new System.Windows.Forms.Label();
            this.labelCIDT = new System.Windows.Forms.Label();
            this.labelCFN = new System.Windows.Forms.Label();
            this.labelCE = new System.Windows.Forms.Label();
            this.labelCBN = new System.Windows.Forms.Label();
            this.labelCBID = new System.Windows.Forms.Label();
            this.labelCrefID = new System.Windows.Forms.Label();
            this.labelCbikeID = new System.Windows.Forms.Label();
            this.labelCAddress = new System.Windows.Forms.Label();
            this.labelCIDtype = new System.Windows.Forms.Label();
            this.labelCEmail = new System.Windows.Forms.Label();
            this.labelCFullname = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.buttonConfrim = new System.Windows.Forms.Button();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelCbikename = new System.Windows.Forms.Label();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timerCustomerSelection = new System.Windows.Forms.Timer(this.components);
            this.buttonback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonBorrow.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonRegistration.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelDashboard.Controls.Add(this.buttonOpenCam);
            this.panelDashboard.Controls.Add(this.label7);
            this.panelDashboard.Controls.Add(this.label6);
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
            // buttonOpenCam
            // 
            this.buttonOpenCam.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenCam.Location = new System.Drawing.Point(325, 205);
            this.buttonOpenCam.Name = "buttonOpenCam";
            this.buttonOpenCam.Size = new System.Drawing.Size(88, 29);
            this.buttonOpenCam.TabIndex = 27;
            this.buttonOpenCam.Text = "Open";
            this.buttonOpenCam.UseVisualStyleBackColor = true;
            this.buttonOpenCam.Click += new System.EventHandler(this.buttonOpenCam_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(155, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Bike ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Bike Name";
            // 
            // textBoxBikeID
            // 
            this.textBoxBikeID.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBikeID.Location = new System.Drawing.Point(159, 67);
            this.textBoxBikeID.Name = "textBoxBikeID";
            this.textBoxBikeID.ReadOnly = true;
            this.textBoxBikeID.Size = new System.Drawing.Size(123, 26);
            this.textBoxBikeID.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Bike Selection";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCapture
            // 
            this.buttonCapture.Enabled = false;
            this.buttonCapture.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapture.Location = new System.Drawing.Point(436, 205);
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
            this.pictureBoxCameraImage.Location = new System.Drawing.Point(325, 45);
            this.pictureBoxCameraImage.Name = "pictureBoxCameraImage";
            this.pictureBoxCameraImage.Size = new System.Drawing.Size(200, 154);
            this.pictureBoxCameraImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCameraImage.TabIndex = 21;
            this.pictureBoxCameraImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(389, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Camera";
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAddress.Location = new System.Drawing.Point(22, 333);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(502, 35);
            this.richTextBoxAddress.TabIndex = 12;
            this.richTextBoxAddress.Text = "";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(18, 309);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 21);
            this.labelAddress.TabIndex = 18;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxSelected
            // 
            this.textBoxSelected.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelected.Location = new System.Drawing.Point(24, 67);
            this.textBoxSelected.Name = "textBoxSelected";
            this.textBoxSelected.ReadOnly = true;
            this.textBoxSelected.Size = new System.Drawing.Size(129, 26);
            this.textBoxSelected.TabIndex = 17;
            // 
            // labelCustomerBikeSelected
            // 
            this.labelCustomerBikeSelected.AutoSize = true;
            this.labelCustomerBikeSelected.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerBikeSelected.ForeColor = System.Drawing.Color.Black;
            this.labelCustomerBikeSelected.Location = new System.Drawing.Point(3, 7);
            this.labelCustomerBikeSelected.Name = "labelCustomerBikeSelected";
            this.labelCustomerBikeSelected.Size = new System.Drawing.Size(242, 21);
            this.labelCustomerBikeSelected.TabIndex = 16;
            this.labelCustomerBikeSelected.Text = "Customer\'s Bike Selected:";
            // 
            // buttonBikeSelection
            // 
            this.buttonBikeSelection.BackColor = System.Drawing.Color.White;
            this.buttonBikeSelection.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBikeSelection.Location = new System.Drawing.Point(437, 379);
            this.buttonBikeSelection.Name = "buttonBikeSelection";
            this.buttonBikeSelection.Size = new System.Drawing.Size(88, 29);
            this.buttonBikeSelection.TabIndex = 13;
            this.buttonBikeSelection.Text = "Next";
            this.buttonBikeSelection.UseVisualStyleBackColor = false;
            this.buttonBikeSelection.Click += new System.EventHandler(this.buttonBikeSelection_Click);
            // 
            // comboBoxIDtype
            // 
            this.comboBoxIDtype.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIDtype.FormattingEnabled = true;
            this.comboBoxIDtype.Items.AddRange(new object[] {
            "",
            "Student ID",
            "Driver License",
            "National ID",
            "Brgy ID",
            "Postal ID",
            "Other"});
            this.comboBoxIDtype.Location = new System.Drawing.Point(22, 279);
            this.comboBoxIDtype.Name = "comboBoxIDtype";
            this.comboBoxIDtype.Size = new System.Drawing.Size(224, 27);
            this.comboBoxIDtype.TabIndex = 10;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(22, 226);
            this.textBoxPhoneNumber.MaxLength = 11;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(224, 26);
            this.textBoxPhoneNumber.TabIndex = 9;
            // 
            // textBoxRefid
            // 
            this.textBoxRefid.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRefid.Location = new System.Drawing.Point(297, 280);
            this.textBoxRefid.Name = "textBoxRefid";
            this.textBoxRefid.Size = new System.Drawing.Size(228, 26);
            this.textBoxRefid.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(23, 173);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(259, 26);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullname.Location = new System.Drawing.Point(24, 120);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(258, 26);
            this.textBoxFullname.TabIndex = 7;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.labelPhoneNumber.Location = new System.Drawing.Point(18, 202);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(140, 21);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelRefId
            // 
            this.labelRefId.AutoSize = true;
            this.labelRefId.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefId.ForeColor = System.Drawing.Color.Black;
            this.labelRefId.Location = new System.Drawing.Point(293, 257);
            this.labelRefId.Name = "labelRefId";
            this.labelRefId.Size = new System.Drawing.Size(57, 19);
            this.labelRefId.TabIndex = 5;
            this.labelRefId.Text = "Ref Id";
            // 
            // labelIDtype
            // 
            this.labelIDtype.AutoSize = true;
            this.labelIDtype.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDtype.ForeColor = System.Drawing.Color.Black;
            this.labelIDtype.Location = new System.Drawing.Point(18, 255);
            this.labelIDtype.Name = "labelIDtype";
            this.labelIDtype.Size = new System.Drawing.Size(78, 21);
            this.labelIDtype.TabIndex = 4;
            this.labelIDtype.Text = "ID Type";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(19, 149);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 21);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.ForeColor = System.Drawing.Color.Black;
            this.labelFullname.Location = new System.Drawing.Point(18, 96);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(92, 21);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labeltimeanddate);
            this.panel1.Controls.Add(this.labelCAdd);
            this.panel1.Controls.Add(this.labelCRID);
            this.panel1.Controls.Add(this.labelCIDT);
            this.panel1.Controls.Add(this.labelCFN);
            this.panel1.Controls.Add(this.labelCE);
            this.panel1.Controls.Add(this.labelCBN);
            this.panel1.Controls.Add(this.labelCBID);
            this.panel1.Controls.Add(this.labelCrefID);
            this.panel1.Controls.Add(this.labelCbikeID);
            this.panel1.Controls.Add(this.labelCAddress);
            this.panel1.Controls.Add(this.labelCIDtype);
            this.panel1.Controls.Add(this.labelCEmail);
            this.panel1.Controls.Add(this.labelCFullname);
            this.panel1.Controls.Add(this.panelPayment);
            this.panel1.Controls.Add(this.labelCbikename);
            this.panel1.Controls.Add(this.pictureBoxCamera);
            this.panel1.Controls.Add(this.labelImage);
            this.panel1.Controls.Add(this.labelInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 422);
            this.panel1.TabIndex = 17;
            // 
            // labeltimeanddate
            // 
            this.labeltimeanddate.AutoSize = true;
            this.labeltimeanddate.BackColor = System.Drawing.Color.White;
            this.labeltimeanddate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimeanddate.Location = new System.Drawing.Point(319, 43);
            this.labeltimeanddate.Name = "labeltimeanddate";
            this.labeltimeanddate.Size = new System.Drawing.Size(45, 19);
            this.labeltimeanddate.TabIndex = 30;
            this.labeltimeanddate.Text = "Time";
            // 
            // labelCAdd
            // 
            this.labelCAdd.AutoSize = true;
            this.labelCAdd.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAdd.ForeColor = System.Drawing.Color.Black;
            this.labelCAdd.Location = new System.Drawing.Point(14, 261);
            this.labelCAdd.Name = "labelCAdd";
            this.labelCAdd.Size = new System.Drawing.Size(57, 15);
            this.labelCAdd.TabIndex = 29;
            this.labelCAdd.Text = "Address";
            // 
            // labelCRID
            // 
            this.labelCRID.AutoSize = true;
            this.labelCRID.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCRID.ForeColor = System.Drawing.Color.Black;
            this.labelCRID.Location = new System.Drawing.Point(163, 209);
            this.labelCRID.Name = "labelCRID";
            this.labelCRID.Size = new System.Drawing.Size(45, 15);
            this.labelCRID.TabIndex = 28;
            this.labelCRID.Text = "Ref Id";
            // 
            // labelCIDT
            // 
            this.labelCIDT.AutoSize = true;
            this.labelCIDT.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCIDT.ForeColor = System.Drawing.Color.Black;
            this.labelCIDT.Location = new System.Drawing.Point(14, 209);
            this.labelCIDT.Name = "labelCIDT";
            this.labelCIDT.Size = new System.Drawing.Size(57, 15);
            this.labelCIDT.TabIndex = 27;
            this.labelCIDT.Text = "ID Type";
            // 
            // labelCFN
            // 
            this.labelCFN.AutoSize = true;
            this.labelCFN.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCFN.ForeColor = System.Drawing.Color.Black;
            this.labelCFN.Location = new System.Drawing.Point(14, 111);
            this.labelCFN.Name = "labelCFN";
            this.labelCFN.Size = new System.Drawing.Size(63, 15);
            this.labelCFN.TabIndex = 26;
            this.labelCFN.Text = "Fullname";
            // 
            // labelCE
            // 
            this.labelCE.AutoSize = true;
            this.labelCE.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCE.ForeColor = System.Drawing.Color.Black;
            this.labelCE.Location = new System.Drawing.Point(14, 160);
            this.labelCE.Name = "labelCE";
            this.labelCE.Size = new System.Drawing.Size(39, 15);
            this.labelCE.TabIndex = 25;
            this.labelCE.Text = "Email";
            // 
            // labelCBN
            // 
            this.labelCBN.AutoSize = true;
            this.labelCBN.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCBN.ForeColor = System.Drawing.Color.Black;
            this.labelCBN.Location = new System.Drawing.Point(14, 62);
            this.labelCBN.Name = "labelCBN";
            this.labelCBN.Size = new System.Drawing.Size(76, 15);
            this.labelCBN.TabIndex = 24;
            this.labelCBN.Text = "Bike Name";
            // 
            // labelCBID
            // 
            this.labelCBID.AutoSize = true;
            this.labelCBID.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCBID.ForeColor = System.Drawing.Color.Black;
            this.labelCBID.Location = new System.Drawing.Point(177, 62);
            this.labelCBID.Name = "labelCBID";
            this.labelCBID.Size = new System.Drawing.Size(54, 15);
            this.labelCBID.TabIndex = 23;
            this.labelCBID.Text = "Bike ID";
            // 
            // labelCrefID
            // 
            this.labelCrefID.AutoSize = true;
            this.labelCrefID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrefID.ForeColor = System.Drawing.Color.Black;
            this.labelCrefID.Location = new System.Drawing.Point(162, 186);
            this.labelCrefID.Name = "labelCrefID";
            this.labelCrefID.Size = new System.Drawing.Size(65, 21);
            this.labelCrefID.TabIndex = 22;
            this.labelCrefID.Text = "Ref ID";
            // 
            // labelCbikeID
            // 
            this.labelCbikeID.AutoSize = true;
            this.labelCbikeID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCbikeID.ForeColor = System.Drawing.Color.Black;
            this.labelCbikeID.Location = new System.Drawing.Point(176, 41);
            this.labelCbikeID.Name = "labelCbikeID";
            this.labelCbikeID.Size = new System.Drawing.Size(73, 21);
            this.labelCbikeID.TabIndex = 21;
            this.labelCbikeID.Text = "Bike ID";
            // 
            // labelCAddress
            // 
            this.labelCAddress.AutoSize = true;
            this.labelCAddress.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAddress.ForeColor = System.Drawing.Color.Black;
            this.labelCAddress.Location = new System.Drawing.Point(13, 240);
            this.labelCAddress.Name = "labelCAddress";
            this.labelCAddress.Size = new System.Drawing.Size(81, 21);
            this.labelCAddress.TabIndex = 20;
            this.labelCAddress.Text = "Address";
            // 
            // labelCIDtype
            // 
            this.labelCIDtype.AutoSize = true;
            this.labelCIDtype.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCIDtype.ForeColor = System.Drawing.Color.Black;
            this.labelCIDtype.Location = new System.Drawing.Point(13, 186);
            this.labelCIDtype.Name = "labelCIDtype";
            this.labelCIDtype.Size = new System.Drawing.Size(78, 21);
            this.labelCIDtype.TabIndex = 19;
            this.labelCIDtype.Text = "ID Type";
            // 
            // labelCEmail
            // 
            this.labelCEmail.AutoSize = true;
            this.labelCEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEmail.ForeColor = System.Drawing.Color.Black;
            this.labelCEmail.Location = new System.Drawing.Point(13, 139);
            this.labelCEmail.Name = "labelCEmail";
            this.labelCEmail.Size = new System.Drawing.Size(55, 21);
            this.labelCEmail.TabIndex = 18;
            this.labelCEmail.Text = "Email";
            // 
            // labelCFullname
            // 
            this.labelCFullname.AutoSize = true;
            this.labelCFullname.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCFullname.ForeColor = System.Drawing.Color.Black;
            this.labelCFullname.Location = new System.Drawing.Point(13, 90);
            this.labelCFullname.Name = "labelCFullname";
            this.labelCFullname.Size = new System.Drawing.Size(88, 21);
            this.labelCFullname.TabIndex = 17;
            this.labelCFullname.Text = "Fullname";
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelPayment.Controls.Add(this.textBoxPayment);
            this.panelPayment.Controls.Add(this.numericUpDownHour);
            this.panelPayment.Controls.Add(this.buttonConfrim);
            this.panelPayment.Controls.Add(this.labelPayment);
            this.panelPayment.Controls.Add(this.labelHours);
            this.panelPayment.Enabled = false;
            this.panelPayment.Location = new System.Drawing.Point(83, 279);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(413, 140);
            this.panelPayment.TabIndex = 16;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPayment.Location = new System.Drawing.Point(198, 55);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(150, 28);
            this.textBoxPayment.TabIndex = 22;
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHour.Location = new System.Drawing.Point(67, 56);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(110, 28);
            this.numericUpDownHour.TabIndex = 21;
            this.numericUpDownHour.ValueChanged += new System.EventHandler(this.numericUpDownHour_ValueChanged);
            // 
            // buttonConfrim
            // 
            this.buttonConfrim.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfrim.Location = new System.Drawing.Point(307, 98);
            this.buttonConfrim.Name = "buttonConfrim";
            this.buttonConfrim.Size = new System.Drawing.Size(70, 27);
            this.buttonConfrim.TabIndex = 20;
            this.buttonConfrim.Text = "Confirm";
            this.buttonConfrim.UseVisualStyleBackColor = true;
            this.buttonConfrim.Click += new System.EventHandler(this.buttonConfrim_Click);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.ForeColor = System.Drawing.Color.White;
            this.labelPayment.Location = new System.Drawing.Point(194, 32);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(87, 21);
            this.labelPayment.TabIndex = 19;
            this.labelPayment.Text = "Payment";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.ForeColor = System.Drawing.Color.White;
            this.labelHours.Location = new System.Drawing.Point(63, 32);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(62, 21);
            this.labelHours.TabIndex = 17;
            this.labelHours.Text = "Hours";
            // 
            // labelCbikename
            // 
            this.labelCbikename.AutoSize = true;
            this.labelCbikename.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCbikename.ForeColor = System.Drawing.Color.Black;
            this.labelCbikename.Location = new System.Drawing.Point(13, 41);
            this.labelCbikename.Name = "labelCbikename";
            this.labelCbikename.Size = new System.Drawing.Size(103, 21);
            this.labelCbikename.TabIndex = 15;
            this.labelCbikename.Text = "Bike Name";
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BackColor = System.Drawing.Color.White;
            this.pictureBoxCamera.Location = new System.Drawing.Point(330, 107);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(200, 154);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamera.TabIndex = 14;
            this.pictureBoxCamera.TabStop = false;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.ForeColor = System.Drawing.Color.Black;
            this.labelImage.Location = new System.Drawing.Point(399, 75);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(61, 21);
            this.labelImage.TabIndex = 3;
            this.labelImage.Text = "Image";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.ForeColor = System.Drawing.Color.Black;
            this.labelInformation.Location = new System.Drawing.Point(49, 2);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(241, 21);
            this.labelInformation.TabIndex = 1;
            this.labelInformation.Text = "Customer\'s Information:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.buttonback);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 77);
            this.panel2.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(22, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(314, 40);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "BIKE RENTAL SYSTEM";
            // 
            // timerCustomerSelection
            // 
            this.timerCustomerSelection.Enabled = true;
            this.timerCustomerSelection.Tick += new System.EventHandler(this.timerCustomerSelection_Tick);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(685, 18);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(84, 37);
            this.buttonback.TabIndex = 24;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date & Time:";
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Label labelCbikename;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Label labelCEmail;
        private System.Windows.Forms.Label labelCFullname;
        private System.Windows.Forms.Label labelCAddress;
        private System.Windows.Forms.Label labelCIDtype;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxBikeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCbikeID;
        private System.Windows.Forms.Label labelCrefID;
        private System.Windows.Forms.Label labelCAdd;
        private System.Windows.Forms.Label labelCRID;
        private System.Windows.Forms.Label labelCIDT;
        private System.Windows.Forms.Label labelCFN;
        private System.Windows.Forms.Label labelCE;
        private System.Windows.Forms.Label labelCBN;
        private System.Windows.Forms.Label labelCBID;
        private System.Windows.Forms.Button buttonOpenCam;
        private System.Windows.Forms.Label labeltimeanddate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonback;
    }
}