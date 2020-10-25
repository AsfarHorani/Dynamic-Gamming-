using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Gamming
{
    public partial class CustomerUI : Form
    {
        Controller c = new Controller();
      
        DBAccess objDBAccess = new DBAccess();
        DataTable dt = new DataTable();
        string name; int mobile_number; double hour;
        DataRow dr;
        public CustomerUI()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {

            dt.Clear();
            string query = "Select * from Customer_Data";
            objDBAccess.readDatathroughAdapter(query, dt);
            gv_customer.DataSource = dt;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select ID--" };

            ui_id.ValueMember = "ID";
            ui_id.DisplayMember = "ID";
            ui_id.DataSource = dt;

            objDBAccess.closeConn();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (ui_name.Text == "" || ui_mobileno.Text == "" || ui_hours.Text == "")
                {
                    throw new Exception("Please fill all the values");
                }


                else
                {
                    this.name = ui_name.Text;

                    this.mobile_number =Convert.ToInt32(ui_mobileno.Text);
                    this.hour = Convert.ToDouble(ui_hours.Text);

                    c.addCustomer(new Customer(this.name, this.mobile_number,this.hour));
                     displayData();
                     clearFields();
                }




            }
            catch (ArgumentNullException ex)
            {
                lbl_msg.Text = "*" + ex.Message;
            }
            catch (InvalidCastException ex)
            {
                lbl_msg.Text = "*" + ex.Message;
            }
            catch (Exception ex)
            {
                lbl_msg.Text = "*" + ex.Message;
            }
        }

        public void clearFields()
        {
            ui_name.Text = "";

            ui_mobileno.Text = "";
            ui_hours.Text = "";
            lbl_msg.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = ui_id.Text;
            string query = "DELETE from Customer_Data  Where ID = ' " + id + "'";
            try
            {
                SqlCommand deletecommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deletecommand);
                if (row == 1)
                {
                    MessageBox.Show("Account is deleted Succesfully");

                    displayData();
                    clearFields();
                }
                else
                {
                    throw new Exception("Something went wrong1 try again.");
                }
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ui_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
