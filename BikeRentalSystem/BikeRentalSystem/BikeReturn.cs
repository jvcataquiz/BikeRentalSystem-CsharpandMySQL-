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
using BikeRentalSystem;
namespace BikeRentalSystem
{
    public partial class BikeReturn : Form
    {
        string datenow ;
        string[] parts;
        string hours;
        string timeleft;
        public string cashierusername;

        string returnid;
        public BikeReturn()
        {
            InitializeComponent();
        }

      
        private void load()
        {
        
            MySqlConnection returnconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
            MySqlDataReader returnreader;

            MySqlCommand returncmd = new MySqlCommand("select customername,cusimage,dateborrow,timeborrow,returntime,hours,payment,bikeid,bikename,cashierusernameborrow,id  from bikereturn where availability = @flag and status = @status;", returnconnection); ;

            returncmd.Parameters.AddWithValue("@flag", 0);
            returncmd.Parameters.AddWithValue("@status", "Okay");

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

        private void BikeReturn_Load(object sender, EventArgs e)
        {
         
            comboBoxStatus.SelectedIndex = 0;
            comboBoxAll.SelectedIndex =0;   
         
        }
    
        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                    DataGridViewRow row = this.dataGridViewDisplay.Rows[e.RowIndex];
                    textBoxReturnID.Text = row.Cells[7].Value.ToString();
                    textBoxCustomerName.Text = row.Cells[0].Value.ToString();
                    returnid = row.Cells[10].Value.ToString();
                    hours = row.Cells[4].Value.ToString();
                    panelinput.Enabled = true;
               
                  
               
               
                  

            }
            catch (Exception)
            {

                MessageBox.Show("Do not Select more than one cell");
            }

               
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
          
            MySqlConnection returnconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
            MySqlDataReader returnreader;

            MySqlCommand returncmd = new MySqlCommand("UPDATE bikereturn SET timereturn=@timereturn,status=@status,remarks=@remarks,cashierusernamereturn =@cashierusernamereturn, timeextension =@timeextension ,availability=@availability where id=@id", returnconnection);

            parts = datenow.Split();

                returnconnection.Open();
                returncmd.Parameters.AddWithValue("@id", returnid);
                returncmd.Parameters.AddWithValue("@timereturn", parts[1] + " " + parts[2]);
                returncmd.Parameters.AddWithValue("@status", this.comboBoxStatus.Text);
                returncmd.Parameters.AddWithValue("@remarks", this.richTextBoxremark.Text);
                returncmd.Parameters.AddWithValue("@cashierusernamereturn", cashierusername);
                returncmd.Parameters.AddWithValue("@timeextension", this.textBoxExtention.Text);
           

            //**************************************************************************************************************************************

            if (comboBoxStatus.Text.Equals("Okay"))
            {


                returncmd.Parameters.AddWithValue("@availability",1);

                returnreader = returncmd.ExecuteReader();

                returnconnection.Close();
                MySqlConnection bikeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
                MySqlDataReader bikereader;
                MySqlCommand bikecmd = new MySqlCommand("UPDATE biketable SET bikeavailability=@bikeavailability where id=@id", bikeconnection);
                bikeconnection.Open();
                bikecmd.Parameters.AddWithValue("@id", this.textBoxReturnID.Text);
                bikecmd.Parameters.AddWithValue("@bikeavailability", 1);
                bikereader = bikecmd.ExecuteReader();
                bikeconnection.Close();
                MessageBox.Show("Data successcully Updated");
            }
            else
            {
                returncmd.Parameters.AddWithValue("@availability", 0);
                returnreader = returncmd.ExecuteReader();

                returnconnection.Close();
                MessageBox.Show("Hold the ID of the Customer!!! Pay the bike/damage part");
               
            }

           

            //**************************************************************************************************************************************

            load();
            

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxremark.Text = "";
        }

        private void timerreturn_Tick(object sender, EventArgs e)
        {
            datenow = DateTime.Now.ToString();
            DateTime timeborrowed = DateTime.Now;

            labeltime.Text = timeborrowed.ToShortDateString();

            parts = datenow.Split();
            labelTimeleft.Visible = false;
            if (hours != null && comboBoxAll.SelectedIndex == 0 && hours != "")
            {
                labelTimeleft.Visible = true;
                labelTimeleft.Text = Convert.ToString(DateTime.Parse(hours) - DateTime.Parse(parts[1] + " " + parts[2]));
                if (labelTimeleft.Text.Contains("-"))
                {
                    labelTimeleft.ForeColor = System.Drawing.Color.Red;
                    textBoxExtention.Text = labelTimeleft.Text;
                }
                else
                {
                    labelTimeleft.ForeColor = System.Drawing.Color.Black;
                    textBoxExtention.Text = "0";
                }
            }
            else
            {
                labelTimeleft.Text = "";
            }

            if (comboBoxStatus.SelectedIndex == 0)
            {
                richTextBoxremark.Enabled = false;
                buttonEnter.Enabled = true;
            }
            else
            {
                richTextBoxremark.Enabled = true;

                if (richTextBoxremark.Text.Length > 3)
                {
                    buttonEnter.Enabled = true;
                }
                else
                {
                    buttonEnter.Enabled = false;
                }
            }

        }


        private void comboBoxAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAll.SelectedIndex == 0)
            {
                
                load();
            }
            else if (comboBoxAll.SelectedIndex == 1)
            {
                
                MySqlConnection returnconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
                MySqlDataReader returnreader;

                MySqlCommand returncmd = new MySqlCommand("select customername,cusimage,dateborrow,timeborrow,returntime,hours,payment,bikeid,bikename,cashierusernameborrow, id ,remarks from bikereturn where status = 'Damaged'", returnconnection);
                //MySqlCommand returncmd = new MySqlCommand("select customername,cusimage,dateborrow,timeborrow,returntime,hours,payment,bikeid,bikename,cashierusernameborrow from bikereturn where availability = '"+false+"');", returnconnection);
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
            else
            {
                
                MySqlConnection returnconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
                MySqlDataReader returnreader;

                MySqlCommand returncmd = new MySqlCommand("select customername,cusimage,dateborrow,timeborrow,returntime,hours,payment,bikeid,bikename,cashierusernameborrow, id  from bikereturn where status = 'Missing'", returnconnection);
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
            textBoxCustomerName.Text = "";
            textBoxReturnID.Text = "";
            labelTimeleft.Text = "";
           
            hours = "";
        }

        private void BikeReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            EmployeeOption back = new EmployeeOption();

            back.cashierusername = cashierusername;
            back.Show();
            this.Hide();
        }

    }
}
