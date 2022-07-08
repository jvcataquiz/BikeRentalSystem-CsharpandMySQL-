using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
namespace BikeRentalSystem
{
    public partial class ImageSlider : Form
    {
        //int  _counter=0;
        //int fileCount = Directory.GetFiles(@"Controls/Design/imgtry/").Length;
        //  bool flag = true;
        private PictureBox pic ;
        private Button view;
        public string selectflag;
        public ImageSlider()
        {
            InitializeComponent();
           
        }

        MySqlConnection bikeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
        MySqlDataReader bikereader;
      
        private void timerImage_Tick(object sender, EventArgs e)
        {
            //Dashboard dashboarddata = new Dashboard();
            //dashboarddata.customerSelected =
        }
        private  void myButton_Click( object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ViewImage view = new ViewImage();
           
            view.viewname = btn.Text;
            view.Show();
            //textBoxCustomerSelected.Text = btn.Text;
        }
        private void ImageSlider_Load(object sender, EventArgs e)
        {


            bikeconnection.Open();
            MySqlCommand bikecmd = new MySqlCommand("select bikeimg , bikename from biketable where bikeavailability='" + 1 + "'", bikeconnection);
            bikereader = bikecmd.ExecuteReader();


            while (bikereader.Read())
            {
                long len = bikereader.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                bikereader.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                pic = new PictureBox();
                pic.Width = 150;
                pic.Height = 150;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                view= new Button();

                view.Text = bikereader["bikename"].ToString();
                view.TabStop = false;
                view.Dock = DockStyle.Bottom;

                //view = new Button();
                //select.Text = bikereader["bikename"].ToString();
                //select.TabStop = false;
                //select.Dock = DockStyle.Bottom;


               view.Click += new EventHandler(myButton_Click);
                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;


               
                pic.Controls.Add(view);
                flowLayoutPanelDisplay.Controls.Add(pic);


            }


        }

       
    }

    }
