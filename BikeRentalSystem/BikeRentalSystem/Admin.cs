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
using MySql.Data.MySqlClient;
namespace BikeRentalSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            BikeRentalSystem.rounded diplayPanel = new rounded();
            diplayPanel.roundedElements(panelDisplay);
        }

        private void buttonPowerOff_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            MySqlConnection adminconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
            MySqlCommand admincmd = new MySqlCommand("select * from admintable where username=@username and password=@password;", adminconnection);
            MySqlDataReader adminreader;
            admincmd.Parameters.AddWithValue("@username", this.textBoxUsername.Text);
            admincmd.Parameters.AddWithValue("@password", this.textBoxPassword.Text);
            adminconnection.Open();
            adminreader = admincmd.ExecuteReader();
           
            if (adminreader.Read())
            {
                MessageBox.Show("Welcome  " + textBoxUsername.Text);
              
                adminconnection.Close();
                AdminDashboard admindash = new AdminDashboard();
                this.Hide();
                admindash.Show();

            }
            else
            {
                adminconnection.Close();

                MySqlConnection Employeeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
                MySqlCommand Employeecmd = new MySqlCommand("select * from employeetable where username=@username and password=@password;", Employeeconnection);
                MySqlDataReader Employeereader;
                Employeecmd.Parameters.AddWithValue("@username", this.textBoxUsername.Text);
                Employeecmd.Parameters.AddWithValue("@password", this.textBoxPassword.Text);
                Employeeconnection.Open();
                Employeereader = Employeecmd.ExecuteReader();
                int employeecount = 0;
                
                while (Employeereader.Read())
                {
                    employeecount = employeecount + 1;
                }

                if (employeecount == 1)
                {
                    MessageBox.Show("Welcome  " + textBoxUsername.Text);
                    Employeeconnection.Close();
                    EmployeeOption employeeopt = new EmployeeOption();
                    employeeopt.cashierusername = textBoxUsername.Text;
                    employeeopt.Show();

                    this.Hide();

                   
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                adminconnection.Close();
               
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
