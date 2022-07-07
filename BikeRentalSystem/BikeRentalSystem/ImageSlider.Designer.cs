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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageSlider));
            this.pictureBoxImageSlider = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.timerImage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImageSlider
            // 
            this.pictureBoxImageSlider.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxImageSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImageSlider.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImageSlider.Name = "pictureBoxImageSlider";
            this.pictureBoxImageSlider.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxImageSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageSlider.TabIndex = 0;
            this.pictureBoxImageSlider.TabStop = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.Location = new System.Drawing.Point(740, 172);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 50);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPrev.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrev.BackgroundImage")));
            this.buttonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrev.FlatAppearance.BorderSize = 0;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Location = new System.Drawing.Point(0, 172);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(55, 50);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // timerImage
            // 
            this.timerImage.Enabled = true;
            this.timerImage.Interval = 2000;
            this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // ImageSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxImageSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImageSlider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageSlider";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImageSlider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImageSlider;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Timer timerImage;
    }
}