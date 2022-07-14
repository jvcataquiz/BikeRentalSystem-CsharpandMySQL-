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
        string val;
        string var;
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            adminview();
          
            comboBoxDropdown.SelectedIndex = 0;
            comboBoxDropdownBike.SelectedIndex = 0;
           

        }
        private void adminview()
        {
            
            MySqlConnection returnconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
            MySqlDataReader returnreader;

            MySqlCommand returncmd = new MySqlCommand("select customername,cusimage,returntime,hours,payment,bikeid,bikename,dateborrow,timeborrow,cashierusernameborrow,cashierusernamereturn, remarks from bikereturn", returnconnection);
            returnconnection.Open();
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = returncmd;
            DataTable data_table = new DataTable();
            data.Fill(data_table);
            dataGridViewDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewDisplay.DataSource = data_table;

            DataGridViewImageColumn datagrid = new DataGridViewImageColumn();
            datagrid = (DataGridViewImageColumn)dataGridViewDisplay.Columns[1];
            datagrid.Width = 120;

            datagrid.ImageLayout = DataGridViewImageCellLayout.Zoom;
            returnconnection.Close();
        }
        private void tabControlAdminDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControlAdminDashboard.SelectedIndex == 0)
            {
                
                timerUpdater.Stop();
                timerUpdaterBike.Stop();
                adminview();
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
            comboBoxDropdownBike.SelectedIndex = 0;
            comboBoxDropdown.SelectedIndex = 0;
        }

        //******************************************************Cashier Code Start Here*********************************//
        MySqlConnection adminconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
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
                panelLeft.Visible = false;
            }
            else if (comboBoxDropdown.SelectedIndex == 1)
            {
                textBoxEmployeeId.Enabled = false;
                panelInputs.Visible = true;
                this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;

                panelLeft.Visible = true;
                buttonAddorUpdateorDelete.Text = "Add";
            }
            else if (comboBoxDropdown.SelectedIndex == 2)
            {
                
                panelInputs.Visible = true;
                this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
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
                this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
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
            dataGridViewDisplayAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        MySqlConnection bikeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
        MySqlDataReader bikereader;

        private void timerUpdaterBike_Tick(object sender, EventArgs e)
        {

            if (comboBoxDropdownBike.SelectedIndex == 0)
            {
                panelleftbike2342.Visible = false;

                this.panelrightbike.Dock = System.Windows.Forms.DockStyle.Fill;

            }
            else if (comboBoxDropdownBike.SelectedIndex == 1)
            {
                textBoxBikeId.Enabled = false;
                panelBikeInput.Visible = true;
                this.panelrightbike.Dock = System.Windows.Forms.DockStyle.Fill;
                panelleftbike2342.Visible = true;
                buttonBike.Text = "Add";
              
            }
            else if (comboBoxDropdownBike.SelectedIndex == 2)
            {

                panelBikeInput.Visible = true;
                this.panelrightbike.Dock = System.Windows.Forms.DockStyle.Fill;
                panelleftbike2342.Visible = true;
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
                    bikereader.Read();

                    if (bikereader.HasRows)
                    {
                        textBoxBikeName.Text = bikereader["bikename"].ToString();
                        textBoxBikeColor.Text = bikereader["bikecolor"].ToString();
                        byte[] image = ((byte[])bikereader["bikeimg"]);
                        
                        MemoryStream mstreem = new MemoryStream(image);
                        pictureBoxBikeImage.Image = Image.FromStream(mstreem);
                       
                      
                        timerUpdaterBike.Stop();

                    }
                    else
                    {
                        bikefillnodata();
                        timerUpdaterBike.Start();
                    }

                    bikeconnection.Close();
                }



            }
            else
            {
                bikeconnection.Close();
                this.panelrightbike.Dock = System.Windows.Forms.DockStyle.Fill;
                panelleftbike2342.Visible = true;
                textBoxBikeId.Enabled = true;
                buttonBike.Text = "Delete";
                panelBikeInput.Visible = false;
                timerUpdaterBike.Stop();
            }

        }

        private void buttonBike_Click(object sender, EventArgs e)
        {
            

                if (buttonBike.Text == "Add")
            {

                bikeconnection.Close();
                MemoryStream ms = new MemoryStream();
                pictureBoxBikeImage.Image.Save(ms, pictureBoxBikeImage.Image.RawFormat);
                byte[] img = ms.ToArray();
                MySqlCommand bikecmd = new MySqlCommand("INSERT INTO  biketable(bikename,bikecolor,bikeavailability,bikeimg) VALUES(@bikename, @bikecolor,@bikeavailability,@bikeimg);", bikeconnection);
                bikeconnection.Open();
                
                bikecmd.Parameters.AddWithValue("@bikename", this.textBoxBikeName.Text);
                bikecmd.Parameters.AddWithValue("@bikecolor", this.textBoxBikeColor.Text);
                bikecmd.Parameters.AddWithValue("@bikeavailability", true);
                bikecmd.Parameters.AddWithValue("@bikeimg",img);
             
                bikereader = bikecmd.ExecuteReader();
                MessageBox.Show("Data Successfully Added");
                bikeconnection.Close();
                pictureBoxBikeImage.Image = null;
                BikeAllData();
                bikeresetdata();
            }
            else if (buttonBike.Text == "Update")
            {
                bikeconnection.Close();
                MemoryStream ms = new MemoryStream();
                pictureBoxBikeImage.Image.Save(ms, pictureBoxBikeImage.Image.RawFormat);
                byte[] img = ms.ToArray();

                if (pathpicture != null)
                {
                    MySqlCommand bikecmd = new MySqlCommand("UPDATE biketable SET bikename=@name,bikecolor=@color,bikeimg=@img where id=@id", bikeconnection);
                    bikeconnection.Open();
                    bikecmd.Parameters.AddWithValue("@id", this.textBoxBikeId.Text);
                    bikecmd.Parameters.AddWithValue("@name", this.textBoxBikeName.Text);
                    bikecmd.Parameters.AddWithValue("@color", this.textBoxBikeColor.Text);
                    bikecmd.Parameters.AddWithValue("@img", img);
                    bikereader = bikecmd.ExecuteReader();
                    bikeconnection.Close();
                    pictureBoxBikeImage.Image = null;

                }
                else
                {
                    MySqlCommand bikecmd = new MySqlCommand("UPDATE biketable SET bikename=@name,bikecolor=@color where id=@id", bikeconnection);
                    bikeconnection.Open();
                    bikecmd.Parameters.AddWithValue("@id", this.textBoxBikeId.Text);
                    bikecmd.Parameters.AddWithValue("@name", this.textBoxBikeName.Text);
                    bikecmd.Parameters.AddWithValue("@color", this.textBoxBikeColor.Text);
                    bikereader = bikecmd.ExecuteReader();
                    bikeconnection.Close();
                }
                MessageBox.Show("Data Successfully Updated");
                bikeconnection.Close();
                BikeAllData();
                timerUpdaterBike.Start();
                bikeresetdata();
            }
            else
            {
                bikeconnection.Close();
                MySqlCommand bikecmd = new MySqlCommand("Delete From biketable where id=@id", bikeconnection);
                bikeconnection.Open();
                bikecmd.Parameters.AddWithValue("@id", this.textBoxBikeId.Text);
                bikereader = bikecmd.ExecuteReader();
                MessageBox.Show("Data Successfully Deleted");
                bikeconnection.Close();
                BikeAllData();


            }

        }
        private void BikeAllData()
        {

            bikeconnection.Close();
            MySqlCommand bikecmd = new MySqlCommand("select id,bikename,bikecolor,bikeavailability,bikeimg from biketable", bikeconnection);
            bikeconnection.Open();
            MySqlDataAdapter bikedata = new MySqlDataAdapter();
            bikedata.SelectCommand = bikecmd;
            DataTable bikedata_table = new DataTable();
            bikedata.Fill(bikedata_table);
            dataGridViewBike.DataSource = bikedata_table;
            dataGridViewBike.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            DataGridViewImageColumn datagrid = new DataGridViewImageColumn();
            datagrid = (DataGridViewImageColumn)dataGridViewBike.Columns[4];
            datagrid.ImageLayout = DataGridViewImageCellLayout.Zoom;
           
            bikeconnection.Close();
            timerUpdaterBike.Stop();
        }


        private void buttonChooseBikeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd  = new OpenFileDialog();
            openfd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png;) | *.jpg;*.jpeg; *.gif; *.png:";
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
            bikeresetdata();
            textBoxBikeId.Text = "";
        }


        private void bikeresetdata()
        {
            TextBox[] btnonetoninereset = new[] { textBoxBikeName, textBoxBikeColor };
            foreach (var i in btnonetoninereset)
            {
                i.Text = "";
            }
            pictureBoxBikeImage.Image = null;

        }

        private void bikefillnodata()
        {
            TextBox[] btnonetoninereset = new[] { textBoxBikeName, textBoxBikeColor };
            foreach (var i in btnonetoninereset)
            {
                i.Text = "No Data Found";
            }
            pictureBoxBikeImage.Image = null;
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin back = new Admin();
            back.Show();
            this.Hide();
        }

        private void tabPageCashier_Click(object sender, EventArgs e)
        {

        }

      


        private void searchview(string myvar,string myval)
        {
            string returnconnection = "server=localhost;username=root;password=root;database=bikesystem";
           MySqlConnection conn = new MySqlConnection(returnconnection);    
            MySqlDataAdapter data;

            DataTable data_table;
           conn.Open();

            data = new MySqlDataAdapter("select customername,cusimage,returntime,hours,payment,bikeid,bikename,dateborrow,timeborrow,cashierusernameborrow,cashierusernamereturn, remarks from bikereturn WHERE customername LIKE '" + myval + "%'", conn);

            data_table = new DataTable();
            data.Fill(data_table);

            
            dataGridViewDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewDisplay.DataSource = data_table;

            DataGridViewImageColumn datagrid = new DataGridViewImageColumn();
            datagrid = (DataGridViewImageColumn)dataGridViewDisplay.Columns[1];
            datagrid.Width = 120;

            datagrid.ImageLayout = DataGridViewImageCellLayout.Zoom;
            conn.Close();
        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            timerUpdater.Stop();
            timerUpdaterBike.Stop();
            if (textBoxSearch.Text != "")
            {
                searchview(var, this.textBoxSearch.Text);
            }
        }
    }
}
