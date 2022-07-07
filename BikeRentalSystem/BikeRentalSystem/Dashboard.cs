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
                    buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
                    break;
                case "Borrow":
                    tabControlDashboard.SelectedIndex = 1;
                    buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
                    buttonBorrow.BackColor = System.Drawing.Color.Gray;
                    buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
                    break;
                case "Return":
                    buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
                    buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
                    buttonReturn.BackColor = System.Drawing.Color.Gray;
                    break;
                default:
                   
                    break;
            }
          
        }

        private void buttonPowerOff_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
