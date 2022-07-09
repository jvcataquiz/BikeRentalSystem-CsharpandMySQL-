using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 
using AForge.Video.DirectShow; 
using System.IO; 
using AForge;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using BikeRentalSystem;
namespace BikeRentalSystem
{
    public partial class Dashboard : Form
    {
        public string customerSelected;
        public string customerSelectedid;
        VideoCaptureDevice cameraDisplay;
        FilterInfoCollection videocamCollection;

        //for old data of the customer
        public string customerName;
        public string customerEmail;
        public string customerPhoneNumber;
        public string customerIDtype;
        public string customerIdRef;
        public string customerAddress;


        public Dashboard()
        {
            InitializeComponent();
            BikeRentalSystem.rounded diplayPanel = new rounded();
            diplayPanel.roundedElements(panelAside);
        }

        private void btnDashboard(object sender, EventArgs e)
        {
            Button btnclick = (Button)sender;
            switch (btnclick.Text)
            {
                case "Registration":
                    tabControlDashboard.SelectedIndex = 0;
                    buttonRegistration.BackColor = System.Drawing.Color.Gray;
                    buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
                    break;
                case "Borrow":
                    tabControlDashboard.SelectedIndex = 1;
                    buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
                    buttonBorrow.BackColor = System.Drawing.Color.Gray;
                    break;

                default:
                    tabControlDashboard.SelectedIndex = 0;
                    buttonRegistration.BackColor = System.Drawing.Color.Gray;
                    buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
                    break;
            }

        }

        private void buttonPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfrim_Click(object sender, EventArgs e)
        {
            MySqlConnection customerconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
            MySqlDataReader customerreader;



            //MemoryStream ms = new MemoryStream();
            //pictureBoxBikeImage.Image.Save(ms, pictureBoxBikeImage.Image.RawFormat);
            //byte[] img = ms.ToArray();
            //MySqlCommand customercmd = new MySqlCommand("INSERT INTO customer (customername, customeraddress, customeremail,customerphone,customeridtype,customerrefid,bikeid,bikename, borrowdate,borrowtime,borrowhour,payment,customerimg)
            //SELECT bike.id, bikename from biketable bike
            //VALUES(@customername,@customeraddress, @customeremail,@customerphone,@customeridtype,@customerrefid,@bikeid, @bikename, @borrowdate,@borrowtime,@borrowhour,@payment,@customerimg);", customerconnection);



            customerconnection.Open();

            //customercmd.Parameters.AddWithValue("@customername", this.textBoxBikeName.Text);
            //customercmd.Parameters.AddWithValue("@customeraddress", this.textBoxBikeColor.Text);
            //customercmd.Parameters.AddWithValue("@customeremail", true);
            //customercmd.Parameters.AddWithValue("@customerphone", this.textBoxBikeName.Text);
            //customercmd.Parameters.AddWithValue("@customeridtype", this.textBoxBikeColor.Text);
            //customercmd.Parameters.AddWithValue("@customerrefid", true);
            //customercmd.Parameters.AddWithValue("@bikeid", this.textBoxBikeName.Text);
            //customercmd.Parameters.AddWithValue("@bikename", this.textBoxBikeColor.Text);
            //customercmd.Parameters.AddWithValue("@borrowdate", this.textBoxBikeName.Text);
            //customercmd.Parameters.AddWithValue("@borrowtime", this.textBoxBikeColor.Text);
            //customercmd.Parameters.AddWithValue("@borrowthour", true);
            //customercmd.Parameters.AddWithValue("@payment", true);
            //customercmd.Parameters.AddWithValue("@customerimg", img);

            //customerreader = customercmd.ExecuteReader();
         
            MessageBox.Show("Data successcully Added");
            customerconnection.Close();
            TextBox[] btnonettext = new[] { textBoxFullname, textBoxEmail, textBoxPhoneNumber, textBoxRefid };
            foreach (var i in btnonettext)
            {
                i.Text = "";
               

            }
            richTextBoxAddress.Text = "";
            pictureBoxCameraImage.Image = null;
            tabControlDashboard.SelectedIndex = 0;
            buttonRegistration.BackColor = System.Drawing.Color.Gray;
            buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
        }

       
        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBoxCameraImage.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           textBoxFullname.Text = customerName;
            textBoxEmail.Text = customerEmail;
           textBoxPhoneNumber.Text = customerPhoneNumber;
             comboBoxIDtype.SelectedIndex = Convert.ToInt32(customerIDtype);
          textBoxRefid.Text = customerIdRef;
          richTextBoxAddress.Text = customerAddress;

            videocamCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cameraDisplay = new VideoCaptureDevice(videocamCollection[0].MonikerString);
            cameraDisplay.NewFrame += CaptureDevice_NewFrame;

            textBoxSelected.Text = customerSelected;
            textBoxBikeID.Text = customerSelectedid;
            if (!String.IsNullOrEmpty(textBoxSelected.Text))
            {
                panelPayment.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cameraDisplay.Stop();
            ImageSlider imgslide = new ImageSlider();
            imgslide.customerNameImage = textBoxFullname.Text;
            imgslide.customerEmailImage = textBoxEmail.Text;
            imgslide.customerPhoneNumberImage = textBoxPhoneNumber.Text;
            imgslide.customerIDtypeImage = comboBoxIDtype.SelectedIndex.ToString();
            imgslide.customerIdRefImage = textBoxRefid.Text;
            imgslide.customerAddressImage = richTextBoxAddress.Text;


            imgslide.Show();
            this.Hide();
        }

        private void buttonBikeSelection_Click(object sender, EventArgs e)
        {

            labelCbikename.Text = textBoxSelected.Text;
            labelCbikeID.Text = textBoxBikeID.Text;
            labelCFullname.Text = textBoxFullname.Text;
           
          labelCEmail.Text =  textBoxEmail.Text;

            labelCIDtype.Text = comboBoxIDtype.Text;
            labelCrefID.Text = textBoxRefid.Text;
            labelCAddress.Text = richTextBoxAddress.Text;
            tabControlDashboard.SelectedIndex = 1;
            buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            buttonBorrow.BackColor = System.Drawing.Color.Gray;
        }


        private void buttonCapture_Click(object sender, EventArgs e)
        {
            if (buttonCapture.Text == "Capture")
            {
                buttonCapture.Text = "Captured";
                cameraDisplay.Stop();
               
                pictureBoxCamera.Image = pictureBoxCameraImage.Image;
            }
            else
            {
                pictureBoxCameraImage.Image = null;
                buttonCapture.Text = "Capture";
                
            }
        }

        private void timerCustomerSelection_Tick(object sender, EventArgs e)
        {
            if (numericUpDownHour.Value != 0)
            {
                textBoxPayment.Text = Convert.ToString(100 * numericUpDownHour.Value);
                timerCustomerSelection.Stop();
                buttonConfrim.Enabled = true;
            }
            else
            {
                textBoxPayment.Text = Convert.ToString(100 * numericUpDownHour.Value);
                buttonConfrim.Enabled = false;
            }

            TextBox[] btnonettext = new[] {textBoxFullname,textBoxEmail,textBoxPhoneNumber, textBoxRefid };
            foreach (var i in btnonettext)
            {
                if (i.Text.Equals("") || richTextBoxAddress.Text.Equals("") || pictureBoxCameraImage.Image == null)
                {
                    buttonBikeSelection.Enabled = false;
                }
                else
                {
                    buttonBikeSelection.Enabled = true;
                }
               
            }
           
        }
        private void numericUpDownHour_ValueChanged(object sender, EventArgs e)
        {
            timerCustomerSelection.Start();
        }

        private void buttonOpenCam_Click(object sender, EventArgs e)
        { 
           
            if (buttonOpenCam.Text.Equals("Open"))
            {
                buttonCapture.Enabled = true;
                buttonCapture.Text = "Capture";
                cameraDisplay.Start();
                buttonOpenCam.Text = "Close";
            }
            else
            {
                buttonCapture.Enabled = false;
                pictureBoxCameraImage.Image = null;
                cameraDisplay.Stop();
                buttonOpenCam.Text = "Open";
            }
        }
    }
}
