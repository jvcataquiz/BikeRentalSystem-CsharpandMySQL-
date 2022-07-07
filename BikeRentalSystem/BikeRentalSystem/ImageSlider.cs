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
        private TextBox bikeid;
        private Button select;
        public ImageSlider()
        {
            InitializeComponent();
        }

        MySqlConnection bikeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
        MySqlDataReader bikereader;

        private void timerImage_Tick(object sender, EventArgs e)
        {
            if ( bikeconnection.State == ConnectionState.Closed)
            {
                bikeconnection.Open();
                MySqlCommand bikecmd = new MySqlCommand("select bikeimg , id from biketable where bikeavailability='" + 1 + "'", bikeconnection);
                bikereader = bikecmd.ExecuteReader();
            }
            else
            {

                while (bikereader.Read())
                {
                    long len = bikereader.GetBytes(0, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    bikereader.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                    pic = new PictureBox();
                    pic.Width = 150;
                    pic.Height = 150;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;

                    bikeid = new TextBox();
                    bikeid.Text = bikereader["id"].ToString();
                    bikeid.Size = new System.Drawing.Size(228, 20);
                    bikeid.Dock = DockStyle.Top;



                    select = new Button();
                    if (select.Enabled)
                    {
                        select.Text = "Select";
                    }
                    else
                    {
                        select.Text = bikereader["id"].ToString();
                    }

                    select.Dock = DockStyle.Bottom;


                    select.Click += new EventHandler(myButton_Click);
                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;


                    pic.Controls.Add(bikeid);
                    pic.Controls.Add(select);
                    flowLayoutPanelDisplay.Controls.Add(pic);


                }

                bikeconnection.Close();
            }


        
            
}
      private  void myButton_Click( object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
           
        }
        private void ImageSlider_Load(object sender, EventArgs e)
        {

        


        }
       
    }

    }
