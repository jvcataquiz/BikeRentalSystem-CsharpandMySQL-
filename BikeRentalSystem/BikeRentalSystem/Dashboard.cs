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
      
        public string cashierusername;


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
            MemoryStream ms = new MemoryStream();

            int width = Convert.ToInt32(pictureBoxCamera.Width );
            int height = Convert.ToInt32(pictureBoxCamera.Height);
            Bitmap bmp = new Bitmap(width, height);
            pictureBoxCamera.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = ms.ToArray();

            DateTime dateborrowed = DateTime.Now;
            DateTime timeborrowed = DateTime.Now;

            MySqlConnection customerconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
            MySqlDataReader customerreader;
           

            string timebr = Convert.ToString(timeborrowed.AddHours(Convert.ToDouble(numericUpDownHour.Value)));
            string[] timeparts = timebr.Split();

            MySqlCommand customercmd = new MySqlCommand("INSERT INTO cutomer (customername, customeraddress, customeremail,customerphone,customeridtype,customerrefid,bikeid,bikename, borrowdate,borrowtime,borrowhour,returntime,payment,customerimg) VALUES(@customername, @customeraddress, @customeremail, @customerphone, @customeridtype, @customerrefid, @bikeid, @bikename, @borrowdate, @borrowtime, @borrowhour,@returntime, @payment, @customerimg); ", customerconnection);
            customerconnection.Open();


            customercmd.Parameters.AddWithValue("@customername", this.textBoxFullname.Text);
            customercmd.Parameters.AddWithValue("@customeraddress", this.richTextBoxAddress.Text);
            customercmd.Parameters.AddWithValue("@customeremail", this.textBoxEmail.Text);
            customercmd.Parameters.AddWithValue("@customerphone", this.textBoxPhoneNumber.Text);
            customercmd.Parameters.AddWithValue("@customeridtype", comboBoxIDtype.Text);
            customercmd.Parameters.AddWithValue("@customerrefid", this.textBoxRefid.Text);
            customercmd.Parameters.AddWithValue("@bikeid", this.textBoxBikeID.Text);
            customercmd.Parameters.AddWithValue("@bikename", this.textBoxSelected.Text);
            customercmd.Parameters.AddWithValue("@borrowdate", dateborrowed.ToShortDateString());
            customercmd.Parameters.AddWithValue("@borrowtime", timeborrowed.ToLongTimeString());
            customercmd.Parameters.AddWithValue("@borrowhour",this.numericUpDownHour.Value);
            customercmd.Parameters.AddWithValue("@returntime", timeparts[1]);
            customercmd.Parameters.AddWithValue("@payment", Convert.ToInt32(this.textBoxPayment.Text));
            customercmd.Parameters.AddWithValue("@customerimg", img);

            customerreader = customercmd.ExecuteReader();
            customerconnection.Close();


            //**************************************************************************************************************************************






            MySqlConnection bikeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
            MySqlDataReader bikereader;
            MySqlCommand bikecmd = new MySqlCommand("UPDATE biketable SET bikeavailability=@bikeavailability where id=@id", bikeconnection);
            bikeconnection.Open();
            bikecmd.Parameters.AddWithValue("@id", this.textBoxBikeID.Text);
            bikecmd.Parameters.AddWithValue("@bikeavailability", 0);
            bikereader = bikecmd.ExecuteReader();
            bikeconnection.Close();


            //**************************************************************************************************************************************


            MySqlConnection returnconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
            MySqlDataReader returnreader;

            string timebreturn = Convert.ToString(timeborrowed.AddHours(Convert.ToDouble(numericUpDownHour.Value)));
            string[] returnparts = timebreturn.Split();
            MessageBox.Show(returnparts[1] + " " + returnparts[2]);

            MySqlCommand returncmd = new MySqlCommand("INSERT INTO bikereturn(cashierusernameborrow,dateborrow,timeborrow,hours,returntime,payment,customername,cusimage,bikeid,bikename) VALUES(@cashierusernameborrow,@dateborrow,@timeborrow,@hours,@rtime,@payment_total,@customer_name,@cusimage,@bike_id,@bike_name); ", returnconnection);
            returnconnection.Open();


            returncmd.Parameters.AddWithValue("@cashierusernameborrow", cashierusername );
            returncmd.Parameters.AddWithValue("@customer_name", this.textBoxFullname.Text);
            returncmd.Parameters.AddWithValue("@cusimage", img);

            returncmd.Parameters.AddWithValue("@dateborrow", dateborrowed.ToShortDateString());
            returncmd.Parameters.AddWithValue("@timeborrow", timeborrowed.ToLongTimeString());
            returncmd.Parameters.AddWithValue("@hours", this.numericUpDownHour.Value);
            returncmd.Parameters.AddWithValue("@rtime", returnparts[1] + " "+ returnparts[2]); 

            returncmd.Parameters.AddWithValue("@payment_total", Convert.ToInt32(this.textBoxPayment.Text));

            returncmd.Parameters.AddWithValue("@bike_id", this.textBoxBikeID.Text);
            returncmd.Parameters.AddWithValue("@bike_name", this.textBoxSelected.Text);

            returnreader = returncmd.ExecuteReader();
            returnconnection.Close();














            MessageBox.Show("Data successcully Added");
          
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
               
                pictureBoxCamera.Image = new Bitmap(pictureBoxCameraImage.Image);
            }
            else
            {
                pictureBoxCameraImage.Image = null;
                buttonCapture.Text = "Capture";
                
            }
        }

        private void timerCustomerSelection_Tick(object sender, EventArgs e)
        {

           string datenow= DateTime.Now.ToString();
           string[] parts =   datenow.Split();
         
            labeldate.Text = parts[0];
            labeltime.Text = parts[1];


            labeltimeanddate.Text = datenow;

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
