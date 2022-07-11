using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentalSystem
{
    public partial class EmployeeOption : Form
    {

        public string cashierusername;

        public EmployeeOption()
        {
            InitializeComponent();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            ImageSlider imgslider = new ImageSlider();
            imgslider.cashierusername = cashierusername;
            imgslider.Show();
            this.Hide();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
           BikeReturn returnbike = new BikeReturn();
            returnbike.cashierusername = cashierusername;
            returnbike.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
