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
    public partial class Form1 : Form
    {
        bool login =false;
        DBAccess objDBAcess = new DBAccess();
        DataTable dt = new DataTable();
        


        public Form1()
        {
            InitializeComponent();
            adminLoginDisplay(login);
            ui_passwordtxt.PasswordChar = '*';
            lbl_date.Text = DateTime.Now.ToLongDateString();
            StartTimer();
            customize_submenu_panel.Visible = false;
        }


        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToShortTimeString();
        }




        public void adminLoginDisplay(bool login)
        {
            if (login==true)
            {
                //  openHeaderForm(new AdminLoginHeaderForm());
                pnl_login.Visible = false;
                pnl_admininfo.Visible = true;
                pnl_login.Hide();
                lbl_username.Text = "@" + ui_usernametxt.Text.ToLower();
                pnl_admininfo.Show();
                btn_customize.Show();
                
               
         


               
            }
            else
            {

                // openHeaderForm(new NoAdminLoginHeaderForm());
                customize_submenu_panel.Visible = false;
                btn_customize.Hide();
                pnl_admininfo.Hide();
                pnl_login.Show();
            }
           
           
            
        }
     


       

        public void hideSubMenu()
        {
            if (customize_submenu_panel.Visible == true)
            {
                customize_submenu_panel.Visible = false;
            }
        }

        public void showSubMenu()
        {
            if (customize_submenu_panel.Visible == false)
            {
                hideSubMenu();
                customize_submenu_panel.Visible = true;
            }
            else
            {
                customize_submenu_panel.Visible = false;
            }

        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


       // private Form activeHeaderForm = null;
      /*  private void openHeaderForm(Form childForm)
        {
            if (activeHeaderForm != null)
                activeHeaderForm.Close();
            activeHeaderForm = childForm;
          childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            headerpanel.Controls.Add(childForm);
            headerpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



  

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        

      
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        

        private void panellogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customize_submenu_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_displayslots_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            { activeForm.Close(); }

            hideSubMenu();
           

        }

        private void btn_customize_Click(object sender, EventArgs e)
        {
            showSubMenu();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
           openChildFormInPanel(new AboutUI());
            hideSubMenu();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_slots_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new SlotUI());
            
        }

        private void btn_admins_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AdminUI());

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_displayslots_Click_1(object sender, EventArgs e)
        {
            if(customize_submenu_panel.Visible)
            hideSubMenu();

            SlotDisplayUI objSlotDislayUI=  new SlotDisplayUI();
            objSlotDislayUI.Show();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CustomerUI());
            
        }

        private void btn_games_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GamesUI());
            
   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

            }
            else if (pictureBox2.Visible==true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;

            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;

            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;

            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;

            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;

            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;

            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox1.Visible = true;

            }
           
        }

        private void img_logo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (ui_usernametxt.Text == "" || ui_passwordtxt.Text == "")
                {
                    throw new Exception("Values can't be empty");
                }

                else
                {
                    string un = ui_usernametxt.Text;
                    string pass = ui_passwordtxt.Text;
                    string query = "Select * from  Users Where Username= '" + un + "' AND Password ='" + pass + "'";


                    objDBAcess.readDatathroughAdapter(query, dt);

                    if (dt.Rows.Count == 1)
                    {
                        this.login = true;
                       
                        adminLoginDisplay(this.login);
                        
                        objDBAcess.closeConn();
                        if (activeForm != null)
                        { activeForm.Close(); }
                        MessageBox.Show("Login Successfull!");
                        ui_usernametxt.Text = "";
                        ui_passwordtxt.Text = "";

                    }
                    else
                    {
                        throw new Exception("Username or Password is incorrect");
                    }
                }
            } catch (Exception ex)
            {
                lbl_error.Text = "*"+ ex.Message;
            }


         
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void ui_passwordtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login = false;
            if (activeForm != null)
            { activeForm.Close(); }
            adminLoginDisplay(login);
          


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnl_admininfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
