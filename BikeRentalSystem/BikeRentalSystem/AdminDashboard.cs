using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BikeRentalSystem
{
    public partial class AdminDashboard : Form
    {
        MySqlConnection adminconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
        MySqlDataReader adminreader;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            comboBoxDropdown.SelectedIndex = 0;
            viewAllData();


        }

        private void timerUpdater_Tick(object sender, EventArgs e)
        {
       
            if (comboBoxDropdown.SelectedIndex == 0)
            {
              
                this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;

            }
            else if (comboBoxDropdown.SelectedIndex == 1)
            {
                textBoxEmployeeId.Enabled = false;
                panelInputs.Visible = true;
                this.panelRight.Dock = System.Windows.Forms.DockStyle.None;
                panelLeft.Visible = true;
                buttonAddorUpdateorDelete.Text = "Add";
            }
            else if (comboBoxDropdown.SelectedIndex == 2)
            {
                
                panelInputs.Visible = true;
                this.panelRight.Dock = System.Windows.Forms.DockStyle.None;
                panelLeft.Visible = true;
                textBoxEmployeeId.Enabled = true;
                buttonAddorUpdateorDelete.Text = "Update";
               
                if (adminconnection.State == ConnectionState.Closed)
                {
                    adminconnection.Open();
                    MySqlCommand admincmd = new MySqlCommand("select * from employeetable where id=@id", adminconnection);
                    admincmd.Parameters.AddWithValue("@id", this.textBoxEmployeeId.Text);
                    adminreader = admincmd.ExecuteReader();
                }
                else
                {
                   
                    if (adminreader.Read())
                    {
                        textBoxUsername.Text = adminreader["username"].ToString();
                        textBoxPassword.Text = adminreader["password"].ToString();
                        textBoxName.Text = adminreader["name"].ToString();
                        textBoxAddress.Text = adminreader["address"].ToString();
                        textBoxContact.Text = adminreader["contact"].ToString();
                        textBoxEmail.Text = adminreader["email"].ToString();

                        timerUpdater.Stop();
                       
                    }
                    else
                    {
                        
                            fillnodata();

                        timerUpdater.Start();
                    }

                    adminconnection.Close();
                }

               
            }
            else
            {
                adminconnection.Close();
                this.panelRight.Dock = System.Windows.Forms.DockStyle.None;
                panelLeft.Visible = true;
                textBoxEmployeeId.Enabled = true;
                buttonAddorUpdateorDelete.Text = "Delete";
                panelInputs.Visible = false;
                
            }

        }

        private void buttonAddorUpdateorDelete_Click(object sender, EventArgs e)
        {
            if (buttonAddorUpdateorDelete.Text == "Add")
            {
                MySqlCommand admincmd = new MySqlCommand("INSERT INTO  employeetable(username,password,name,address,contact,email) VALUES('" + this.textBoxUsername.Text + "','" + this.textBoxPassword.Text + "','" + this.textBoxName.Text + "','" + this.textBoxAddress.Text + "','" + textBoxContact.Text + "','" + textBoxEmail.Text + "');", adminconnection);
                adminconnection.Open();
                adminreader = admincmd.ExecuteReader();
                MessageBox.Show("Data successcully Added");
                adminconnection.Close();
                viewAllData();
                resetdata();
            }
            else if (buttonAddorUpdateorDelete.Text == "Update")
            {
                MySqlCommand admincmd = new MySqlCommand("UPDATE employeetable SET username=@username,password=@password,name=@name,address=@address,contact=@contact,email=@email where id=@id", adminconnection);
                adminconnection.Open();
                admincmd.Parameters.AddWithValue("@id", this.textBoxEmployeeId.Text);
                admincmd.Parameters.AddWithValue("@username", this.textBoxUsername.Text);
                admincmd.Parameters.AddWithValue("@password", this.textBoxPassword.Text);
                admincmd.Parameters.AddWithValue("@name", this.textBoxName.Text);
                admincmd.Parameters.AddWithValue("@address", this.textBoxAddress.Text);
                admincmd.Parameters.AddWithValue("@contact", this.textBoxContact.Text);
                admincmd.Parameters.AddWithValue("@email", this.textBoxEmail.Text);
                adminreader = admincmd.ExecuteReader();
                MessageBox.Show("Data successcully Updated");
                adminconnection.Close();
                viewAllData();
                timerUpdater.Start();
                resetdata();
            }
            else
            {
                MySqlCommand admincmd = new MySqlCommand("Delete From employeetable where id=@id", adminconnection);
                adminconnection.Open();
                admincmd.Parameters.AddWithValue("@id", this.textBoxEmployeeId.Text);
                adminreader = admincmd.ExecuteReader();
                MessageBox.Show("Data successcully Deleted");
                adminconnection.Close();
                viewAllData();


            }

        }
        private void viewAllData()
        {
           
           
                MySqlCommand admincmd = new MySqlCommand("select * from employeetable", adminconnection);
                adminconnection.Open();
                MySqlDataAdapter data = new MySqlDataAdapter();
                data.SelectCommand = admincmd;
                DataTable data_table = new DataTable();
                data.Fill(data_table);
                 dataGridViewDisplayAll.DataSource = data_table;
                adminconnection.Close();
       
        }
        private void resetdata()
        {
            TextBox[] btnonetoninereset = new[] { textBoxName, textBoxUsername, textBoxPassword, textBoxEmployeeId, textBoxAddress, textBoxContact, textBoxEmail };
            foreach (var i in btnonetoninereset)
            {
                i.Text = "";
            }
        }

        private void fillnodata()
        {
            TextBox[] btnonetoninereset = new[] { textBoxName, textBoxUsername, textBoxPassword, textBoxAddress, textBoxContact, textBoxEmail };
            foreach (var i in btnonetoninereset)
            {
                i.Text = "No Data Found";
            }
        }
        private void comboBoxDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerUpdater.Start();
            
            resetdata();
        }

        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            timerUpdater.Start();
           
        }

        private void tabControlAdminDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdminDashboard.SelectedIndex == 0)
            {
                
                timerUpdater.Stop();
                timerUpdaterBike.Stop();
            }
            else if (tabControlAdminDashboard.SelectedIndex == 1)
            {
               
                timerUpdater.Start();
                timerUpdaterBike.Stop();
            }
            else
            {
                timerUpdater.Stop();
                timerUpdaterBike.Start();
            }
        }

        private void timerUpdaterBike_Tick(object sender, EventArgs e)
        {

        }
    }
}
