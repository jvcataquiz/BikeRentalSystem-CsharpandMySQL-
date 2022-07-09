namespace BikeRentalSystem
{
    partial class ImageSlider
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
            this.timerImage = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.CustomerSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerImage
            // 
            this.timerImage.Enabled = true;
            this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // flowLayoutPanelDisplay
            // 
            this.flowLayoutPanelDisplay.AutoScroll = true;
            this.flowLayoutPanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDisplay.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelDisplay.Name = "flowLayoutPanelDisplay";
            this.flowLayoutPanelDisplay.Size = new System.Drawing.Size(827, 450);
            this.flowLayoutPanelDisplay.TabIndex = 0;
            // 
            // CustomerSelected
            // 
            this.CustomerSelected.AutoSize = true;
            this.CustomerSelected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSelected.ForeColor = System.Drawing.Color.Red;
            this.CustomerSelected.Location = new System.Drawing.Point(110, 20);
            this.CustomerSelected.Name = "CustomerSelected";
            this.CustomerSelected.Size = new System.Drawing.Size(0, 13);
            this.CustomerSelected.TabIndex = 2;
            // 
            // ImageSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.CustomerSelected);
            this.Controls.Add(this.flowLayoutPanelDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImageSlider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageList";
            this.Load += new System.EventHandler(this.ImageSlider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDisplay;
        private System.Windows.Forms.Label CustomerSelected;
        public System.Windows.Forms.Timer timerImage;
    }
}