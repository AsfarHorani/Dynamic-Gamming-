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
    public partial class SlotUI : Form
    {
        Controller c = new Controller();
       
        DBAccess objDBAccess = new DBAccess();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();

        public SlotUI()
        {
            InitializeComponent();
            addValuesToComboBox();
            displayData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
       

        }

     

        private void guestSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            pnl_guest.Visible = true;
            pnl_guest.Show();
            pnl_guest.BringToFront();

                }

        private void customerSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_customer.Visible = true;
            pnl_customer.Show();
            pnl_customer.BringToFront();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            double hours;
            string date;
            string game;

            try
            {
                if (ui_namecb.Text == "" || ui_gamecb.Text == "" || ui_hourscb.Text == "")
                {
                    throw new Exception("Please fill all the values");
                }

                else
                {
                  
                    name = ui_namecb.Text;
                    hours = Convert.ToDouble(ui_hourscb.Text);
                    game = ui_gamecb.Text;
                    date = ui_datePickercb.Value.ToShortDateString();

                    c.addSlot(new Slot(name,game,hours,date));
                    clearFields();
                    displayData();

                }




            }
            catch (ArgumentNullException ex)
            {
                lbl_slot1.Text = "*" + ex.Message;
            }
            catch (InvalidCastException ex)
            {
                lbl_slot1.Text = "*" + ex.Message;
            }
            catch (Exception ex)
            {
                lbl_slot1.Text = "*" + ex.Message;
            }


        }


        public void displayData()
        {

            dt.Clear();
            string query = "Select * from Slots";
            objDBAccess.readDatathroughAdapter(query, dt);
            gv_slot.DataSource = dt;
            
  
            
            ui_selectedid.ValueMember = "ID";
            ui_selectedid.DisplayMember = "ID";
            ui_selectedid.DataSource = dt;



            dt2.Clear();
            string query2 = "Select * from Games";
            objDBAccess.readDatathroughAdapter(query2, dt2);
           
            ui_gamecb.ValueMember = "ID";
            ui_gamecb.DisplayMember = "Name";
            ui_gamecb.DataSource = dt2;

            dt3.Clear();
            string query3 = "Select * from Customer_Data";
            objDBAccess.readDatathroughAdapter(query3, dt3);

            ui_idcus.ValueMember = "ID";
            ui_idcus.DisplayMember = "ID";
            ui_idcus.DataSource = dt3;


            

            objDBAccess.closeConn();



        }

        public void clearFields()
           {
            ui_namecb.Text = "";
            ui_idcus.Text = "";
            ui_hourscb.Text = "";
            ui_gamecb.Text = "";
            lbl_slot1.Text = "";
            lbl_slot2.Text = "";
            lbl_slot3.Text = "";

        }

        public void addValuesToComboBox()
        {
            ui_hourscb.Items.Clear();

            for (int i = 1; i<= 12; i++)
            {
                ui_hourscb.Items.Add(i);
                ui_hourscus.Items.Add(i);
            }

        }

        private void ui_hours2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = ui_selectedid.Text;
            string query = "DELETE from Slots  Where ID = ' " + id + "'";
            try
            {
                SqlCommand deletecommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deletecommand);
                if (row == 1)
                {
                    MessageBox.Show("Slot is deleted Succesfully");

                    displayData();
                    clearFields();
                }
                else
                {
                    throw new Exception("Something went wrong! try again.");
                }
            }
            catch (Exception ex)
            {
                lbl_slot3.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string name;
            string date;
            double hours;
            
            try
            {
                if (ui_idcus.Text == "" || ui_hourscus.Text == "" )
                {
                    throw new Exception("Please fill all the values");
                }

                else
                {
                     hours = Convert.ToDouble(ui_hourscus.Text);
                     date = ui_datePickercus.Value.ToShortDateString();

                    DBAccess objDBAccess = new DBAccess();
                    DataTable dt3 = new DataTable();
                    dt3.Clear();
                    string query3 = "Select * from Customer_Data";
                    objDBAccess.readDatathroughAdapter(query3, dt3);

                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        if (dt3.Rows[i][0].ToString() == ui_idcus.Text.ToString())
                        {
                            name=dt3.Rows[i][1].ToString();
                            c.addSlot(new Slot(name, hours, date));
                            break;
                        }

                    }
                }
                     
                        
                  clearFields();
                  displayData();
            
            }
            catch (ArgumentNullException ex)
            {
                lbl_slot2.Text = "*" + ex.Message;
            }
            catch (InvalidCastException ex)
            {
                lbl_slot2.Text = "*" + ex.Message;
            }
            catch (Exception ex)
            {
                lbl_slot2.Text = "*" + ex.Message;
            }

        }

        private void add_tab_Click(object sender, EventArgs e)
        {

        }

        private void gv_slot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
