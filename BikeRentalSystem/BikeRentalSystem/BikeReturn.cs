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

        string hours;
        string timeleft;
        public string cashierusername;
        public BikeReturn()
        {
            InitializeComponent();
        }

        private void timerReturn_Tick(object sender, EventArgs e)
        {
            //DateTime timeborrowed = DateTime.Now;

            string datenow = DateTime.Now.ToString();
            string[] parts = datenow.Split();
            if (hours != null)
            {
                labelTimeleft.Text = Convert.ToString(DateTime.Parse(hours)- DateTime.Parse(parts[1]+" "+ parts[2]));
                if (labelTimeleft.Text.Contains("-")) 
                {
                    labelTimeleft.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    labelTimeleft.ForeColor = System.Drawing.Color.Black;
                }
            }

            if (comboBoxStatus.SelectedIndex == 0)
            {
                richTextBoxremark.Enabled = false;
            }
            else
            {
                richTextBoxremark.Enabled = true;
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

        private void BikeReturn_Load(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedIndex = 0;
            MySqlConnection returnconnection = new MySqlConnection(@"server=localhost;username=root;password=root;database=bikerentalsystem");
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

        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                DataGridViewRow row = this.dataGridViewDisplay.Rows[e.RowIndex];
                textBoxReturnID.Text = row.Cells[7].Value.ToString();
                textBoxCustomerName.Text = row.Cells[0].Value.ToString();
            hours = row.Cells[4].Value.ToString();
            panelinput.Enabled = true;
          
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
