using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Gamming
{
    public partial class SlotDisplayUI : Form
    {
        Controller c = new Controller();
        DBAccess objDBAccess = new DBAccess();
        DataTable dt = new DataTable();


        public SlotDisplayUI()
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            StartTimer();
            displayData();
        }

        public void displayData()
        {
            dt.Clear();
            string query = "Select * from Slots";
            objDBAccess.readDatathroughAdapter(query, dt);
            gv_slot.DataSource = dt;
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


        private void SlotDisplayUI_Load(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void btn_fillscreen_Click(object sender, EventArgs e)
        {
            
        }

        private void headerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void img_logo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
