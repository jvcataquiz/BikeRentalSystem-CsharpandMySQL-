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
using System.IO;
namespace BikeRentalSystem
{
    public partial class AdminDashboard : Form
    {
        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            comboBoxDropdown.SelectedIndex = 0;
            comboBoxDropdownBike.SelectedIndex = 0;
          

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
               bikeconnection.Close();
                timerUpdater.Start();
                timerUpdaterBike.Stop();
                viewAllData();
            }
            else
            {
                adminconnection.Close();
                timerUpdater.Stop();
                timerUpdaterBike.Start();
                BikeAllData();
            }
        }

        //******************************************************Cashier Code Start Here*********************************//
        MySqlConnection adminconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
        MySqlDataReader adminreader;
        public AdminDashboard()
        {
            InitializeComponent();
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

            adminconnection.Close();
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
        //******************************************************Cashier Code ends Here*********************************//

        string location;
        string pathpicture;

        MySqlConnection bikeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
        MySqlDataReader bikereader;

        private void timerUpdaterBike_Tick(object sender, EventArgs e)
        {
            if (comboBoxDropdownBike.SelectedIndex == 0)
            {

                this.panelrightbike.Dock = System.Windows.Forms.DockStyle.Fill;

            }
            else if (comboBoxDropdownBike.SelectedIndex == 1)
            {
                textBoxBikeId.Enabled = false;
                panelBikeInput.Visible = true;
                this.panelrightbike.Dock = System.Windows.Forms.DockStyle.None;
                panelleftbike.Visible = true;
                buttonBike.Text = "Add";
            }
            else if (comboBoxDropdownBike.SelectedIndex == 2)
            {

                panelBikeInput.Visible = true;
                this.panelrightbike.Dock = System.Windows.Forms.DockStyle.None;
                panelleftbike.Visible = true;
               textBoxBikeId.Enabled = true;
                buttonBike.Text = "Update";

                if (bikeconnection.State == ConnectionState.Closed)
                {
                    bikeconnection.Open();
                    MySqlCommand bikecmd = new MySqlCommand("select * from biketable where id=@id", bikeconnection);
                    bikecmd.Parameters.AddWithValue("@id", this.textBoxBikeId.Text);
                    bikereader = bikecmd.ExecuteReader();
                }
                else
                {

                    if (bikereader.Read())
                    {
                        textBoxBikeName.Text = bikereader["bikename"].ToString();
                        textBoxBikeColor.Text = bikereader["bikecolor"].ToString();
                        pictureBoxBikeImage.Image = new Bitmap(@"DatabaseImages\" + Path.GetFileName(bikereader["bikeimg"].ToString()));
                        timerUpdaterBike.Stop();

                    }
                    else
                    {

                        timerUpdaterBike.Start();
                    }

                    bikeconnection.Close();
                }



            }
            else
            {
                bikeconnection.Close();
                this.panelrightbike.Dock = System.Windows.Forms.DockStyle.None;
                panelleftbike.Visible = true;
                textBoxBikeId.Enabled = true;
                buttonBike.Text = "Delete";
                panelBikeInput.Visible = false;

            }

        }

        private void buttonBike_Click(object sender, EventArgs e)
        {

            if (buttonBike.Text == "Add")
            {
                pictureBoxBikeImage.ImageLocation = pathpicture;
                MySqlCommand bikecmd = new MySqlCommand("INSERT INTO  biketable(bikename,bikecolor,bikeavailability,bikeimg) VALUES('" + this.textBoxBikeName.Text + "','" + this.textBoxBikeColor.Text + "','" + 1 + "','" + Path.GetFileName(pictureBoxBikeImage.ImageLocation) + "');", bikeconnection);
                bikeconnection.Open();
                bikereader = bikecmd.ExecuteReader();
                MessageBox.Show("Data successcully Added");
                bikeconnection.Close();
                
                if (! File.Exists(@"DatabaseImages\" + Path.GetFileName(pictureBoxBikeImage.ImageLocation)))
                {
                    File.Copy(location, Application.StartupPath + @"\DatabaseImages\" + Path.GetFileName(pictureBoxBikeImage.ImageLocation));
                    
                }

                BikeAllData();
                //resetdata();
            }
            else if (buttonBike.Text == "Update")
            {
                pictureBoxBikeImage.ImageLocation = pathpicture;
               
                if (pathpicture != null)
                {
                    MySqlCommand bikecmd = new MySqlCommand("UPDATE biketable SET bikename=@name,bikecolor=@color,bikeimg=@img where id=@id", bikeconnection);
                    bikeconnection.Open();
                    bikecmd.Parameters.AddWithValue("@id", this.textBoxBikeId.Text);
                    bikecmd.Parameters.AddWithValue("@name", this.textBoxBikeName.Text);
                    bikecmd.Parameters.AddWithValue("@color", this.textBoxBikeColor.Text);
                    bikecmd.Parameters.AddWithValue("@img", Path.GetFileName(pictureBoxBikeImage.ImageLocation));
                    bikereader = bikecmd.ExecuteReader();
                   

                    if (!File.Exists(@"DatabaseImages\" + Path.GetFileName(pictureBoxBikeImage.ImageLocation)))
                    {
                        File.Copy(location, Application.StartupPath + @"\DatabaseImages\" + Path.GetFileName(pictureBoxBikeImage.ImageLocation));

                    }
                }
                else
                {
                    MySqlCommand bikecmd = new MySqlCommand("UPDATE biketable SET bikename=@name,bikecolor=@color where id=@id", bikeconnection);
                    bikeconnection.Open();
                    bikecmd.Parameters.AddWithValue("@id", this.textBoxBikeId.Text);
                    bikecmd.Parameters.AddWithValue("@name", this.textBoxBikeName.Text);
                    bikecmd.Parameters.AddWithValue("@color", this.textBoxBikeColor.Text);
                    bikereader = bikecmd.ExecuteReader();
                    
                }
                MessageBox.Show("Data successcully Updated");
                bikeconnection.Close();
                BikeAllData();
                timerUpdaterBike.Start();
                //resetdata();
            }
            else
            {
                MySqlCommand bikecmd = new MySqlCommand("Delete From biketable where id=@id", bikeconnection);
                bikeconnection.Open();
                bikecmd.Parameters.AddWithValue("@id", this.textBoxBikeId.Text);
                bikereader = bikecmd.ExecuteReader();
                MessageBox.Show("Data successcully Deleted");
                bikeconnection.Close();
                BikeAllData();


            }

        }
        private void BikeAllData()
        {

            bikeconnection.Close();
            MySqlCommand bikecmd = new MySqlCommand("select * from biketable", bikeconnection);
            bikeconnection.Open();
            MySqlDataAdapter bikedata = new MySqlDataAdapter();
            bikedata.SelectCommand = bikecmd;
            DataTable bikedata_table = new DataTable();
            bikedata.Fill(bikedata_table);
            dataGridViewBike.DataSource = bikedata_table;
            bikeconnection.Close();

        }


        private void buttonChooseBikeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd  = new OpenFileDialog();
            openfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif;) | *.jpg;*.jpeg; *.gif:";
           if (openfd.ShowDialog() == DialogResult.OK){

                location = openfd.FileName;
                pictureBoxBikeImage.Image = new Bitmap(openfd.FileName);

                pathpicture = openfd.FileName;
            }
          

        }

        private void textBoxBikeId_TextChanged(object sender, EventArgs e)
        {
            timerUpdaterBike.Start();
        }

        private void comboBoxDropdownBike_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerUpdaterBike.Start();
        }
    }
}
