using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeRentalSystem;
namespace BikeRentalSystem
{
    public partial class Dashboard : Form
    {
        public string customerSelected;

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

            MessageBox.Show(customerSelected);
        }
        
        //private void timerCustomerSelection_Tick(object sender, EventArgs e)
        //{

        //    //textBoxBikeID.Text = customerSelected;
        //    ////    selectedItem = customerSelected;
        //    ////    if (selectedItem != null)
        //    ////    {
        //    ////        selectedItem = customerSelected;
        //    ////        //MessageBox.Show(selectedItem);
        //    ////        timerCustomerSelection.Stop();
        //    ////    }
        //    ////    panelPayment.Enabled = true;
        //    ////if (!String.IsNullOrEmpty(customerSelected))
        //    ////{
        //    ////    panelPayment.Enabled = false;
        //    ////    selectitem = customerSelected;
        //    ////}
        //    ////else {
        //    ////    panelPayment.Enabled = true;
        //    ////    selectitem = customerSelected;
        //    ////}


        //}

        private void Dashboard_Load(object sender, EventArgs e)
        {
            textBoxSelected.Text = customerSelected;
            if (!String.IsNullOrEmpty(textBoxSelected.Text))
            {
                panelPayment.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageSlider imgslide = new ImageSlider();
            imgslide.Show();
            this.Hide();
        }
    }
}
