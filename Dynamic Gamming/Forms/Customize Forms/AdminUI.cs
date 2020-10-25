using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dynamic_Gamming
{
    public partial class AdminUI : Form
    {
        Controller c = new Controller();
        string username, password;
        DBAccess objDBAccess = new DBAccess();
        DataTable dt = new DataTable();
        DataRow dr;
        

        public AdminUI()
        {
            InitializeComponent();
            displayData();
            ui_pass.PasswordChar = '*';
            ui_repass.PasswordChar = '*';


        }

        public void displayData()
        {

            dt.Clear();
            string query = "Select * from Users";
            objDBAccess.readDatathroughAdapter(query, dt);
            dt.Columns.Remove("Password");
            gv_admin.DataSource = dt;


            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select ID--" };
           
            ui_id.ValueMember = "ID";
            ui_id.DisplayMember = "ID";
            ui_id.DataSource = dt;
            
            
            objDBAccess.closeConn();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_tab_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string id = ui_id.Text;
            string query = "DELETE from Users  Where ID = ' " + id + "'";
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

        public void clearFields()
        {
            ui_username.Text = "";
            ui_pass.Text = "";
            ui_repass.Text = "";
            ui_id.Text = "";
            lbl_error.Text = "";
            lbl_msg.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (ui_username.Text == "" || ui_pass.Text == "" || ui_repass.Text == "")
                {
                    throw new Exception("Please fill all the values");
                }

                else if (ui_pass.Text != ui_repass.Text)
                {
                    throw new Exception("Password doesn't match");
                }

                else
                {
                    this.username = ui_username.Text;

                    this.password = ui_pass.Text;

                    c.addAdmin(new Admin(username, password));
                    clearFields();
                    displayData();
                   
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

      
    }
}
