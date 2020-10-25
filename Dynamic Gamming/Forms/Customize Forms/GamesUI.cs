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
    public partial class GamesUI : Form
    {
        string name;
        int relyr;
        bool mul;
        Controller c = new Controller();
        DataRow dr;
        DBAccess objDBAccess = new DBAccess();
        DataTable dt = new DataTable();

        public GamesUI()
        {
            InitializeComponent();
            displayData();

        }

        public bool isMultiplyerSelected()
        {
            if (ui_mulno.Checked || ui_mulyes.Checked)
            {
                return true;
            }
            else {
                return false;
            }
        }


        public void clearFields()
        {
            ui_name.Text = "";

            ui_releaseyr.Text = "";
            ui_id.Text = "";
            ui_mulno.Checked = false;
            ui_mulyes.Checked = false;
            lbl_msg.Text = "";

        }

        public void displayData()
        {
            dt.Clear();
            string query = "Select * from Games";
            objDBAccess.readDatathroughAdapter(query, dt);
            gv_game.DataSource = dt;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select ID--" };

            ui_id.ValueMember = "ID";
            ui_id.DisplayMember = "ID";
            ui_id.DataSource = dt;

            objDBAccess.closeConn();

            ui_genre.Items.Clear();
            ui_genre.Items.Add("Sports");
            ui_genre.Items.Add("Action");
            ui_genre.Items.Add("Strategy");
            ui_genre.Items.Add("Adventure");
            ui_genre.Items.Add("Simulation");
            ui_genre.Items.Add("Others");


        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ui_name.Text == "" || ui_releaseyr.Text == "" || isMultiplyerSelected().Equals(false))
                {

                    throw new Exception("Please fill all the values");
                }

                else
                {
                    this.name = ui_name.Text;
                     string genre = ui_genre.Text;
                    relyr = Convert.ToInt32(ui_releaseyr.Text);
                    if (ui_mulyes.Checked)
                    {
                        this.mul = true;
                    }
                    else if (ui_mulno.Checked)
                    {
                        this.mul = false;
                    }

                    if (genre == "Others")
                    {
                        c.addGame(new Other(name, relyr, mul));
                        
                    }
                   else if (genre == "Action")
                    {
                        c.addGame(new Action(name, relyr, mul));
                    }
                    else if (genre == "Sports")
                    {
                        c.addGame(new Sports(name, relyr, mul));
                    }
                    else if (genre == "Adventure")
                    {
                        c.addGame(new Adventure(name, relyr, mul));
                    }
                    else if (genre == "Simulation")
                    {
                        c.addGame(new Simulation(name, relyr, mul));
                    }
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

        private void ui_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GamesUI_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = ui_id.Text;
            string query = "DELETE from Games  Where ID = ' " + id + "'";
            try
            {
                SqlCommand deletecommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deletecommand);
                if (row == 1)
                {
                    MessageBox.Show("Game is deleted Succesfully");

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
                lbl_error.Text = ex.Message;
            }
        }

        private void gv_game_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
