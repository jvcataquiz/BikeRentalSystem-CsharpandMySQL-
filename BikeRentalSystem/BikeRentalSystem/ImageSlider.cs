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
namespace BikeRentalSystem
{
    public partial class ImageSlider : Form
    {
      int  _counter=0;
      int fileCount = Directory.GetFiles(@"Controls/Design/imgtry/").Length;
        bool flag = true;
        public ImageSlider()
        {
            InitializeComponent();
        }
     

        private void timerImage_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                _counter++;
                nexandprev(fileCount, 0);
            }
            else
            {
                _counter--;
                nexandprev(0, fileCount);
            }
        }

       
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            _counter--;
            timerImage.Stop();
            nexandprev(0, fileCount);
            timerImage.Start();
            flag = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _counter++;
            timerImage.Stop();
            nexandprev(fileCount,0);
            timerImage.Start();
            flag = true;
        }


        private void nexandprev(int x, int y)
        {

            if (_counter == x)
            {
                _counter = y;
            }
            else
            {
                pictureBoxImageSlider.Image = new Bitmap(@"Controls/Design/imgtry/" + _counter + ".jpg");
            }
        }
        private void ImageSlider_Load(object sender, EventArgs e)
        {
            pictureBoxImageSlider.Image = new Bitmap(@"Controls/Design/imgtry/" + 1 + ".jpg");
        }

        
    }
}
