namespace BikeRentalSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.tabControlAdminDashboard = new System.Windows.Forms.TabControl();
            this.tabPageadmin = new System.Windows.Forms.TabPage();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageCashier = new System.Windows.Forms.TabPage();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewDisplayAll = new System.Windows.Forms.DataGridView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.buttonAddorUpdateorDelete = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.comboBoxDropdown = new System.Windows.Forms.ComboBox();
            this.tabPagebike = new System.Windows.Forms.TabPage();
            this.panelrightbike = new System.Windows.Forms.Panel();
            this.dataGridViewBike = new System.Windows.Forms.DataGridView();
            this.panelleftbike2342 = new System.Windows.Forms.Panel();
            this.panelBikeInput = new System.Windows.Forms.Panel();
            this.pictureBoxBikeImage = new System.Windows.Forms.PictureBox();
            this.buttonChooseBikeImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBikeColor = new System.Windows.Forms.TextBox();
            this.textBoxBikeName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBikeId = new System.Windows.Forms.TextBox();
            this.buttonBike = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDropdownBike = new System.Windows.Forms.ComboBox();
            this.timerUpdater = new System.Windows.Forms.Timer(this.components);
            this.timerUpdaterBike = new System.Windows.Forms.Timer(this.components);
            this.tabControlAdminDashboard.SuspendLayout();
            this.tabPageadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.tabPageCashier.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayAll)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.panel.SuspendLayout();
            this.tabPagebike.SuspendLayout();
            this.panelrightbike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBike)).BeginInit();
            this.panelleftbike2342.SuspendLayout();
            this.panelBikeInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBikeImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdminDashboard
            // 
            this.tabControlAdminDashboard.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdminDashboard.Controls.Add(this.tabPageadmin);
            this.tabControlAdminDashboard.Controls.Add(this.tabPageCashier);
            this.tabControlAdminDashboard.Controls.Add(this.tabPagebike);
            this.tabControlAdminDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdminDashboard.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdminDashboard.Multiline = true;
            this.tabControlAdminDashboard.Name = "tabControlAdminDashboard";
            this.tabControlAdminDashboard.SelectedIndex = 0;
            this.tabControlAdminDashboard.Size = new System.Drawing.Size(910, 560);
            this.tabControlAdminDashboard.TabIndex = 0;
            this.tabControlAdminDashboard.TabStop = false;
            this.tabControlAdminDashboard.SelectedIndexChanged += new System.EventHandler(this.tabControlAdminDashboard_SelectedIndexChanged);
            // 
            // tabPageadmin
            // 
            this.tabPageadmin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageadmin.Controls.Add(this.dataGridViewDisplay);
            this.tabPageadmin.Controls.Add(this.panel3);
            this.tabPageadmin.Controls.Add(this.label1);
            this.tabPageadmin.Controls.Add(this.textBoxSearch);
            this.tabPageadmin.Controls.Add(this.panel1);
            this.tabPageadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPageadmin.Location = new System.Drawing.Point(24, 4);
            this.tabPageadmin.Name = "tabPageadmin";
            this.tabPageadmin.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageadmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageadmin.Size = new System.Drawing.Size(882, 552);
            this.tabPageadmin.TabIndex = 0;
            this.tabPageadmin.Text = "Admin";
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.AllowUserToAddRows = false;
            this.dataGridViewDisplay.AllowUserToDeleteRows = false;
            this.dataGridViewDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(3, 70);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.ReadOnly = true;
            this.dataGridViewDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(876, 479);
            this.dataGridViewDisplay.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 479);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Customername:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(34, 23);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSearch.Size = new System.Drawing.Size(362, 31);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 67);
            this.panel1.TabIndex = 3;
            // 
            // tabPageCashier
            // 
            this.tabPageCashier.Controls.Add(this.panelRight);
            this.tabPageCashier.Controls.Add(this.panelLeft);
            this.tabPageCashier.Controls.Add(this.panel);
            this.tabPageCashier.Location = new System.Drawing.Point(24, 4);
            this.tabPageCashier.Name = "tabPageCashier";
            this.tabPageCashier.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageCashier.Size = new System.Drawing.Size(882, 552);
            this.tabPageCashier.TabIndex = 1;
            this.tabPageCashier.Text = "Cashier";
            this.tabPageCashier.UseVisualStyleBackColor = true;
            this.tabPageCashier.Click += new System.EventHandler(this.tabPageCashier_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.DarkGray;
            this.panelRight.Controls.Add(this.dataGridViewDisplayAll);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(237, 35);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(642, 514);
            this.panelRight.TabIndex = 4;
            // 
            // dataGridViewDisplayAll
            // 
            this.dataGridViewDisplayAll.AllowUserToAddRows = false;
            this.dataGridViewDisplayAll.AllowUserToDeleteRows = false;
            this.dataGridViewDisplayAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplayAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDisplayAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDisplayAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisplayAll.GridColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewDisplayAll.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDisplayAll.Name = "dataGridViewDisplayAll";
            this.dataGridViewDisplayAll.ReadOnly = true;
            this.dataGridViewDisplayAll.Size = new System.Drawing.Size(642, 514);
            this.dataGridViewDisplayAll.TabIndex = 0;
            this.dataGridViewDisplayAll.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.panelLeft.Controls.Add(this.panelInputs);
            this.panelLeft.Controls.Add(this.labelEmpID);
            this.panelLeft.Controls.Add(this.textBoxEmployeeId);
            this.panelLeft.Controls.Add(this.buttonAddorUpdateorDelete);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(3, 35);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(234, 514);
            this.panelLeft.TabIndex = 3;
            this.panelLeft.Visible = false;
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.label2);
            this.panelInputs.Controls.Add(this.textBoxEmail);
            this.panelInputs.Controls.Add(this.labelContact);
            this.panelInputs.Controls.Add(this.labelAddress);
            this.panelInputs.Controls.Add(this.labelName);
            this.panelInputs.Controls.Add(this.labelPassword);
            this.panelInputs.Controls.Add(this.labelUsername);
            this.panelInputs.Controls.Add(this.textBoxContact);
            this.panelInputs.Controls.Add(this.textBoxAddress);
            this.panelInputs.Controls.Add(this.textBoxName);
            this.panelInputs.Controls.Add(this.textBoxPassword);
            this.panelInputs.Controls.Add(this.textBoxUsername);
            this.panelInputs.Location = new System.Drawing.Point(3, 77);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(231, 307);
            this.panelInputs.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(3, 245);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(225, 24);
            this.textBoxEmail.TabIndex = 11;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(3, 181);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(62, 16);
            this.labelContact.TabIndex = 10;
            this.labelContact.Text = "Contact";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(3, 136);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(61, 16);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 16);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(3, 46);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 16);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(3, 1);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 16);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(3, 200);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(225, 24);
            this.textBoxContact.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(3, 155);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(225, 24);
            this.textBoxAddress.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(3, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(225, 24);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(3, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(225, 24);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(3, 20);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(225, 24);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.Location = new System.Drawing.Point(6, 29);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(90, 16);
            this.labelEmpID.TabIndex = 14;
            this.labelEmpID.Text = "Employee ID";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Enabled = false;
            this.textBoxEmployeeId.Font = new System.Drawing.Font("MS UI Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeId.Location = new System.Drawing.Point(6, 48);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(225, 24);
            this.textBoxEmployeeId.TabIndex = 13;
            this.textBoxEmployeeId.TextChanged += new System.EventHandler(this.textBoxEmployeeId_TextChanged);
            // 
            // buttonAddorUpdateorDelete
            // 
            this.buttonAddorUpdateorDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddorUpdateorDelete.Location = new System.Drawing.Point(72, 400);
            this.buttonAddorUpdateorDelete.Name = "buttonAddorUpdateorDelete";
            this.buttonAddorUpdateorDelete.Size = new System.Drawing.Size(79, 30);
            this.buttonAddorUpdateorDelete.TabIndex = 12;
            this.buttonAddorUpdateorDelete.Text = "Add";
            this.buttonAddorUpdateorDelete.UseVisualStyleBackColor = true;
            this.buttonAddorUpdateorDelete.Click += new System.EventHandler(this.buttonAddorUpdateorDelete_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel.Controls.Add(this.labelEmployee);
            this.panel.Controls.Add(this.comboBoxDropdown);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(876, 32);
            this.panel.TabIndex = 5;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.White;
            this.labelEmployee.Location = new System.Drawing.Point(284, 5);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(294, 21);
            this.labelEmployee.TabIndex = 3;
            this.labelEmployee.Text = "Employee Information Record";
            // 
            // comboBoxDropdown
            // 
            this.comboBoxDropdown.FormattingEnabled = true;
            this.comboBoxDropdown.Items.AddRange(new object[] {
            "SHOW ALL",
            "ADD",
            "UPDATE",
            "DELETE"});
            this.comboBoxDropdown.Location = new System.Drawing.Point(3, 5);
            this.comboBoxDropdown.Name = "comboBoxDropdown";
            this.comboBoxDropdown.Size = new System.Drawing.Size(113, 21);
            this.comboBoxDropdown.TabIndex = 2;
            this.comboBoxDropdown.TabStop = false;
            this.comboBoxDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBoxDropdown_SelectedIndexChanged);
            // 
            // tabPagebike
            // 
            this.tabPagebike.Controls.Add(this.panelrightbike);
            this.tabPagebike.Controls.Add(this.panelleftbike2342);
            this.tabPagebike.Controls.Add(this.panel2);
            this.tabPagebike.Location = new System.Drawing.Point(24, 4);
            this.tabPagebike.Name = "tabPagebike";
            this.tabPagebike.Size = new System.Drawing.Size(882, 552);
            this.tabPagebike.TabIndex = 2;
            this.tabPagebike.Text = "Bike";
            this.tabPagebike.UseVisualStyleBackColor = true;
            // 
            // panelrightbike
            // 
            this.panelrightbike.BackColor = System.Drawing.Color.DarkGray;
            this.panelrightbike.Controls.Add(this.dataGridViewBike);
            this.panelrightbike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelrightbike.Location = new System.Drawing.Point(236, 32);
            this.panelrightbike.Name = "panelrightbike";
            this.panelrightbike.Size = new System.Drawing.Size(646, 520);
            this.panelrightbike.TabIndex = 7;
            // 
            // dataGridViewBike
            // 
            this.dataGridViewBike.AllowUserToAddRows = false;
            this.dataGridViewBike.AllowUserToDeleteRows = false;
            this.dataGridViewBike.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBike.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBike.Name = "dataGridViewBike";
            this.dataGridViewBike.ReadOnly = true;
            this.dataGridViewBike.Size = new System.Drawing.Size(646, 520);
            this.dataGridViewBike.TabIndex = 0;
            // 
            // panelleftbike2342
            // 
            this.panelleftbike2342.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.panelleftbike2342.Controls.Add(this.panelBikeInput);
            this.panelleftbike2342.Controls.Add(this.label10);
            this.panelleftbike2342.Controls.Add(this.textBoxBikeId);
            this.panelleftbike2342.Controls.Add(this.buttonBike);
            this.panelleftbike2342.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleftbike2342.Location = new System.Drawing.Point(0, 32);
            this.panelleftbike2342.Name = "panelleftbike2342";
            this.panelleftbike2342.Size = new System.Drawing.Size(236, 520);
            this.panelleftbike2342.TabIndex = 6;
            this.panelleftbike2342.Visible = false;
            // 
            // panelBikeInput
            // 
            this.panelBikeInput.Controls.Add(this.pictureBoxBikeImage);
            this.panelBikeInput.Controls.Add(this.buttonChooseBikeImage);
            this.panelBikeInput.Controls.Add(this.label7);
            this.panelBikeInput.Controls.Add(this.label8);
            this.panelBikeInput.Controls.Add(this.label9);
            this.panelBikeInput.Controls.Add(this.textBoxBikeColor);
            this.panelBikeInput.Controls.Add(this.textBoxBikeName);
            this.panelBikeInput.Location = new System.Drawing.Point(3, 77);
            this.panelBikeInput.Name = "panelBikeInput";
            this.panelBikeInput.Size = new System.Drawing.Size(231, 317);
            this.panelBikeInput.TabIndex = 15;
            // 
            // pictureBoxBikeImage
            // 
            this.pictureBoxBikeImage.Location = new System.Drawing.Point(32, 139);
            this.pictureBoxBikeImage.Name = "pictureBoxBikeImage";
            this.pictureBoxBikeImage.Size = new System.Drawing.Size(168, 165);
            this.pictureBoxBikeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBikeImage.TabIndex = 10;
            this.pictureBoxBikeImage.TabStop = false;
            // 
            // buttonChooseBikeImage
            // 
            this.buttonChooseBikeImage.Location = new System.Drawing.Point(6, 110);
            this.buttonChooseBikeImage.Name = "buttonChooseBikeImage";
            this.buttonChooseBikeImage.Size = new System.Drawing.Size(94, 23);
            this.buttonChooseBikeImage.TabIndex = 9;
            this.buttonChooseBikeImage.Text = "Choose Image";
            this.buttonChooseBikeImage.UseVisualStyleBackColor = true;
            this.buttonChooseBikeImage.Click += new System.EventHandler(this.buttonChooseBikeImage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bike Image:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bike Color:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bike Name:";
            // 
            // textBoxBikeColor
            // 
            this.textBoxBikeColor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBikeColor.Location = new System.Drawing.Point(3, 65);
            this.textBoxBikeColor.Name = "textBoxBikeColor";
            this.textBoxBikeColor.Size = new System.Drawing.Size(225, 23);
            this.textBoxBikeColor.TabIndex = 2;
            // 
            // textBoxBikeName
            // 
            this.textBoxBikeName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBikeName.Location = new System.Drawing.Point(3, 20);
            this.textBoxBikeName.Name = "textBoxBikeName";
            this.textBoxBikeName.Size = new System.Drawing.Size(225, 23);
            this.textBoxBikeName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Bike ID";
            // 
            // textBoxBikeId
            // 
            this.textBoxBikeId.Enabled = false;
            this.textBoxBikeId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBikeId.Location = new System.Drawing.Point(3, 48);
            this.textBoxBikeId.Name = "textBoxBikeId";
            this.textBoxBikeId.Size = new System.Drawing.Size(225, 23);
            this.textBoxBikeId.TabIndex = 13;
            this.textBoxBikeId.TextChanged += new System.EventHandler(this.textBoxBikeId_TextChanged);
            // 
            // buttonBike
            // 
            this.buttonBike.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBike.Location = new System.Drawing.Point(73, 400);
            this.buttonBike.Name = "buttonBike";
            this.buttonBike.Size = new System.Drawing.Size(79, 30);
            this.buttonBike.TabIndex = 0;
            this.buttonBike.Text = "Add";
            this.buttonBike.UseVisualStyleBackColor = true;
            this.buttonBike.Click += new System.EventHandler(this.buttonBike_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxDropdownBike);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 32);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bike Information Record";
            // 
            // comboBoxDropdownBike
            // 
            this.comboBoxDropdownBike.FormattingEnabled = true;
            this.comboBoxDropdownBike.Items.AddRange(new object[] {
            "SHOW ALL",
            "ADD",
            "UPDATE",
            "DELETE"});
            this.comboBoxDropdownBike.Location = new System.Drawing.Point(3, 5);
            this.comboBoxDropdownBike.Name = "comboBoxDropdownBike";
            this.comboBoxDropdownBike.Size = new System.Drawing.Size(113, 21);
            this.comboBoxDropdownBike.TabIndex = 2;
            this.comboBoxDropdownBike.TabStop = false;
            this.comboBoxDropdownBike.SelectedIndexChanged += new System.EventHandler(this.comboBoxDropdownBike_SelectedIndexChanged);
            // 
            // timerUpdater
            // 
            this.timerUpdater.Enabled = true;
            this.timerUpdater.Tick += new System.EventHandler(this.timerUpdater_Tick);
            // 
            // timerUpdaterBike
            // 
            this.timerUpdaterBike.Enabled = true;
            this.timerUpdaterBike.Tick += new System.EventHandler(this.timerUpdaterBike_Tick);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 560);
            this.Controls.Add(this.tabControlAdminDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.tabControlAdminDashboard.ResumeLayout(false);
            this.tabPageadmin.ResumeLayout(false);
            this.tabPageadmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.tabPageCashier.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayAll)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.tabPagebike.ResumeLayout(false);
            this.panelrightbike.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBike)).EndInit();
            this.panelleftbike2342.ResumeLayout(false);
            this.panelleftbike2342.PerformLayout();
            this.panelBikeInput.ResumeLayout(false);
            this.panelBikeInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBikeImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdminDashboard;
        private System.Windows.Forms.TabPage tabPageadmin;
        private System.Windows.Forms.TabPage tabPageCashier;
        private System.Windows.Forms.TabPage tabPagebike;
        private System.Windows.Forms.ComboBox comboBoxDropdown;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Button buttonAddorUpdateorDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Timer timerUpdater;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.DataGridView dataGridViewDisplayAll;
        private System.Windows.Forms.Timer timerUpdaterBike;
        private System.Windows.Forms.Panel panelrightbike;
        private System.Windows.Forms.DataGridView dataGridViewBike;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDropdownBike;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelleftbike2342;
        private System.Windows.Forms.Panel panelBikeInput;
        private System.Windows.Forms.PictureBox pictureBoxBikeImage;
        private System.Windows.Forms.Button buttonChooseBikeImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBikeColor;
        private System.Windows.Forms.TextBox textBoxBikeName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBikeId;
        private System.Windows.Forms.Button buttonBike;
    }
}