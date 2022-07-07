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
using System.IO;
namespace BikeRentalSystem
{
    public partial class ImageSlider : Form
    {
        //int  _counter=0;
        //int fileCount = Directory.GetFiles(@"Controls/Design/imgtry/").Length;
        //  bool flag = true;
        private PictureBox pic ;
        private TextBox bikeid;
        public ImageSlider()
        {
            InitializeComponent();
        }

        MySqlConnection bikeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
        MySqlDataReader bikereader;

        private void timerImage_Tick(object sender, EventArgs e)
        {
            //if (flag)
            //{
            //    _counter++;
            //    nexandprev(fileCount, 0);
            //}
            //else
            //{
            //    _counter--;
            //    nexandprev(0, fileCount);
            //}

             

            }

        private void ImageSlider_Load(object sender, EventArgs e)
        {

            bikeconnection.Open();
            MySqlCommand bikecmd = new MySqlCommand("select bikeimg from biketable where bikeavailability=@value", bikeconnection);
            bikecmd.Parameters.AddWithValue("@value", 1);
            bikereader = bikecmd.ExecuteReader();

            int count = 0;

            while (bikereader.Read())
            {


                long len = bikereader.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                bikereader.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));


                pic = new PictureBox();
                pic.Width = 150;
                pic.Height = 150;

                bikeid = new TextBox();
                bikeid.Text = bikereader["id"].ToString();


                pic.BackgroundImageLayout = ImageLayout.Stretch;
                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;
               
                flowLayoutPanelDisplay.Controls.Add(pic);


            }

        }
    }


    //private void buttonPrev_Click(object sender, EventArgs e)
    //{
    //    //_counter--;
    //    //timerImage.Stop();
    //    //nexandprev(0, fileCount);
    //    //timerImage.Start();
    //    //flag = false;
    //}

    //private void buttonNext_Click(object sender, EventArgs e)
    //{
    //    //_counter++;
    //    //timerImage.Stop();
    //    //nexandprev(fileCount,0);
    //    //timerImage.Start();
    //    //flag = true;
    //}


    //private void nexandprev(int x, int y)
    //{

    //    //if (_counter == x)
    //    //{
    //    //    _counter = y;
    //    //}
    //    //else
    //    //{
    //    //    pictureBoxImageSlider.Image = new Bitmap(@"Controls/Design/imgtry/" + _counter + ".jpg");
    //    //}
    //}
  

        
    }
