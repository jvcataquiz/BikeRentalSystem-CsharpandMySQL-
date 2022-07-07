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
            this.SuspendLayout();
            // 
            // timerImage
            // 
            this.timerImage.Enabled = true;
            this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // flowLayoutPanelDisplay
            // 
            this.flowLayoutPanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDisplay.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelDisplay.Name = "flowLayoutPanelDisplay";
            this.flowLayoutPanelDisplay.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelDisplay.TabIndex = 0;
            // 
            // ImageSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImageSlider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageSlider";
            this.Load += new System.EventHandler(this.ImageSlider_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDisplay;
    }
}