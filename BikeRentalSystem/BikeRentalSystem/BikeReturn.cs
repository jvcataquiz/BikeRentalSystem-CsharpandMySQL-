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
    public partial class BikeReturn : Form
    {
        string datenow = DateTime.Now.ToString();
        string[] parts;
        string hours;
        string timeleft;
        public string cashierusername;
        public BikeReturn()
        {
            InitializeComponent();
        }

        private void timerReturn_Tick(object sender, EventArgs e)
        {
            DateTime timeborrowed = DateTime.Now;

            labeltime.Text = timeborrowed.ToShortDateString();

            parts = datenow.Split();

            if (hours != null)
            {
                labelTimeleft.Text = Convert.ToString(DateTime.Parse(hours)- DateTime.Parse(parts[1]+" "+ parts[2]));
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
          
            //if (returnconnection.State == ConnectionState.Closed)
            //{
            //    returnconnection.Open();
            //    MySqlCommand returncmd = new MySqlCommand("select * from bikereturn where id=@id", returnconnection);
            //    returncmd.Parameters.AddWithValue("@id", );
            //    returnreader = returncmd.ExecuteReader();
            //}
            //else
            //{

                //if (returnreader.Read())
                //{
                //    //textBoxUsername.Text = returnreader["username"].ToString();
                //    //textBoxPassword.Text = returnreader["password"].ToString();
                //    //textBoxName.Text = returnreader["name"].ToString();
                //    //textBoxAddress.Text = returnreader["address"].ToString();
                //    //textBoxContact.Text = returnreader["contact"].ToString();
                //    //textBoxEmail.Text = returnreader["email"].ToString();
                //    timerReturn.Start();

                //}
                //else
            //    {


            //        timerReturn.Start();
            //    }

            //    returnconnection.Close();
            //}


        }
        private void load()
        {
            MySqlConnection returnconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
            MySqlDataReader returnreader;
            MySqlCommand returncmd = new MySqlCommand("select customername,cusimage,dateborrow,timeborrow,returntime,hours,payment,bikeid,bikename,cashierusernameborrow from bikereturn", returnconnection);
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
            load();
        }

        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridViewDisplay.Rows[e.RowIndex];
                textBoxReturnID.Text = row.Cells[7].Value.ToString();
                textBoxCustomerName.Text = row.Cells[0].Value.ToString();
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

            MySqlCommand returncmd = new MySqlCommand("UPDATE bikereturn SET timereturn=@timereturn,status=@status,remarks=@remarks,cashierusernamereturn =@cashierusernamereturn, timeextension =@timeextension where id=@id", returnconnection);
            returncmd.Parameters.AddWithValue("@id", this.textBoxReturnID.Text);
            returnreader = returncmd.ExecuteReader();
            parts = datenow.Split();

            if (returnreader.Read())
            {
               
                returncmd.Parameters.AddWithValue("@timereturn", parts[1] + " " + parts[2]);
                returncmd.Parameters.AddWithValue("@status", this.comboBoxStatus.Text);
                returncmd.Parameters.AddWithValue("@remarks", this.richTextBoxremark.Text);
                returncmd.Parameters.AddWithValue("@cashierusernamereturn", cashierusername);
                returncmd.Parameters.AddWithValue("@timeextension", this.textBoxExtention.Text);

                returnreader = returncmd.ExecuteReader();
                MessageBox.Show("Data successcully Updated");

            }
            else
            {
                MessageBox.Show("Data error!!!");

            }



            //**************************************************************************************************************************************

            if (comboBoxStatus.SelectedIndex == 0)
            {
                MySqlConnection bikeconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikesystem");
                MySqlDataReader bikereader;
                MySqlCommand bikecmd = new MySqlCommand("UPDATE biketable SET bikeavailability=@bikeavailability where id=@id", bikeconnection);
                bikeconnection.Open();
                bikecmd.Parameters.AddWithValue("@id", this.textBoxReturnID.Text);
                bikecmd.Parameters.AddWithValue("@bikeavailability", 0);
                bikereader = bikecmd.ExecuteReader();
                bikeconnection.Close();
            }
            else
            {
                MessageBox.Show("Hold the ID of the Customer!!! Pay the bike/damage part");
            }
          


            //**************************************************************************************************************************************

            load();

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxremark.Text = "";
        }
    }
}
