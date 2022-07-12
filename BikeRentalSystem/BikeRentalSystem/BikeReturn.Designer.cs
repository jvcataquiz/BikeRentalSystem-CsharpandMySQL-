namespace BikeRentalSystem
{
    partial class BikeReturn
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
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAll = new System.Windows.Forms.ComboBox();
            this.labeltime = new System.Windows.Forms.Label();
            this.labelTimeleft = new System.Windows.Forms.Label();
            this.labelremarks = new System.Windows.Forms.Label();
            this.panelinput = new System.Windows.Forms.Panel();
            this.textBoxExtention = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxremark = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxReturnID = new System.Windows.Forms.TextBox();
            this.timerreturn = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelinput.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.AllowUserToAddRows = false;
            this.dataGridViewDisplay.AllowUserToDeleteRows = false;
            this.dataGridViewDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.ReadOnly = true;
            this.dataGridViewDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(921, 362);
            this.dataGridViewDisplay.TabIndex = 0;
            this.dataGridViewDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxAll);
            this.panel1.Controls.Add(this.labeltime);
            this.panel1.Controls.Add(this.labelTimeleft);
            this.panel1.Controls.Add(this.labelremarks);
            this.panel1.Controls.Add(this.panelinput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCustomerName);
            this.panel1.Controls.Add(this.textBoxReturnID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 138);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time Left:";
            // 
            // comboBoxAll
            // 
            this.comboBoxAll.FormattingEnabled = true;
            this.comboBoxAll.Items.AddRange(new object[] {
            "All",
            "Damaged",
            "Missing"});
            this.comboBoxAll.Location = new System.Drawing.Point(273, 7);
            this.comboBoxAll.Name = "comboBoxAll";
            this.comboBoxAll.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAll.TabIndex = 2;
            this.comboBoxAll.SelectedIndexChanged += new System.EventHandler(this.comboBoxAll_SelectedIndexChanged);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Location = new System.Drawing.Point(23, 15);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(26, 13);
            this.labeltime.TabIndex = 7;
            this.labeltime.Text = "time";
            // 
            // labelTimeleft
            // 
            this.labelTimeleft.AutoSize = true;
            this.labelTimeleft.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeleft.Location = new System.Drawing.Point(83, 107);
            this.labelTimeleft.Name = "labelTimeleft";
            this.labelTimeleft.Size = new System.Drawing.Size(0, 19);
            this.labelTimeleft.TabIndex = 6;
            // 
            // labelremarks
            // 
            this.labelremarks.AutoSize = true;
            this.labelremarks.Location = new System.Drawing.Point(23, 102);
            this.labelremarks.Name = "labelremarks";
            this.labelremarks.Size = new System.Drawing.Size(54, 13);
            this.labelremarks.TabIndex = 5;
            this.labelremarks.Text = "Time Left:";
            // 
            // panelinput
            // 
            this.panelinput.Controls.Add(this.textBoxExtention);
            this.panelinput.Controls.Add(this.buttonEnter);
            this.panelinput.Controls.Add(this.label4);
            this.panelinput.Controls.Add(this.richTextBoxremark);
            this.panelinput.Controls.Add(this.label3);
            this.panelinput.Controls.Add(this.comboBoxStatus);
            this.panelinput.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelinput.Enabled = false;
            this.panelinput.Location = new System.Drawing.Point(400, 0);
            this.panelinput.Name = "panelinput";
            this.panelinput.Size = new System.Drawing.Size(521, 138);
            this.panelinput.TabIndex = 4;
            // 
            // textBoxExtention
            // 
            this.textBoxExtention.Location = new System.Drawing.Point(21, 101);
            this.textBoxExtention.Name = "textBoxExtention";
            this.textBoxExtention.ReadOnly = true;
            this.textBoxExtention.Size = new System.Drawing.Size(111, 20);
            this.textBoxExtention.TabIndex = 9;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(416, 90);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(102, 36);
            this.buttonEnter.TabIndex = 8;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Remarks";
            // 
            // richTextBoxremark
            // 
            this.richTextBoxremark.Location = new System.Drawing.Point(174, 29);
            this.richTextBoxremark.Name = "richTextBoxremark";
            this.richTextBoxremark.Size = new System.Drawing.Size(221, 97);
            this.richTextBoxremark.TabIndex = 6;
            this.richTextBoxremark.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Okay",
            "Damaged",
            "Missing"});
            this.comboBoxStatus.Location = new System.Drawing.Point(21, 50);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(112, 21);
            this.comboBoxStatus.TabIndex = 0;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bike ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(26, 67);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.ReadOnly = true;
            this.textBoxCustomerName.Size = new System.Drawing.Size(194, 20);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // textBoxReturnID
            // 
            this.textBoxReturnID.Location = new System.Drawing.Point(259, 67);
            this.textBoxReturnID.Name = "textBoxReturnID";
            this.textBoxReturnID.ReadOnly = true;
            this.textBoxReturnID.Size = new System.Drawing.Size(86, 20);
            this.textBoxReturnID.TabIndex = 0;
            // 
            // timerreturn
            // 
            this.timerreturn.Enabled = true;
            this.timerreturn.Tick += new System.EventHandler(this.timerreturn_Tick);
            // 
            // BikeReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDisplay);
            this.MaximizeBox = false;
            this.Name = "BikeReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BikeReturn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BikeReturn_FormClosing);
            this.Load += new System.EventHandler(this.BikeReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelinput.ResumeLayout(false);
            this.panelinput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxReturnID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Panel panelinput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxremark;
        private System.Windows.Forms.Label labelTimeleft;
        private System.Windows.Forms.Label labelremarks;
        private System.Windows.Forms.TextBox textBoxExtention;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timerreturn;
        private System.Windows.Forms.ComboBox comboBoxAll;
        private System.Windows.Forms.Label label6;
    }
}