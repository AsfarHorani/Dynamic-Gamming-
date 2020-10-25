namespace Dynamic_Gamming
{
    partial class SlotUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.add_tab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guestSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_customer = new System.Windows.Forms.Panel();
            this.ui_datePickercus = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_slot2 = new System.Windows.Forms.Label();
            this.ui_idcus = new System.Windows.Forms.ComboBox();
            this.ui_hourscus = new System.Windows.Forms.ComboBox();
            this.btn_addcus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_guest = new System.Windows.Forms.Panel();
            this.ui_datePickercb = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_slot1 = new System.Windows.Forms.Label();
            this.ui_hourscb = new System.Windows.Forms.ComboBox();
            this.ui_gamecb = new System.Windows.Forms.ComboBox();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_namecb = new System.Windows.Forms.TextBox();
            this.remove_tab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ui_selectedid = new System.Windows.Forms.ComboBox();
            this.lbl_slot3 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gv_slot = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.add_tab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_customer.SuspendLayout();
            this.pnl_guest.SuspendLayout();
            this.remove_tab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_slot)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.add_tab);
            this.tabControl1.Controls.Add(this.remove_tab);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(558, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 323);
            this.tabControl1.TabIndex = 4;
            // 
            // add_tab
            // 
            this.add_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_tab.Controls.Add(this.menuStrip1);
            this.add_tab.Controls.Add(this.pnl_guest);
            this.add_tab.Controls.Add(this.pnl_customer);
            this.add_tab.Location = new System.Drawing.Point(4, 28);
            this.add_tab.Name = "add_tab";
            this.add_tab.Padding = new System.Windows.Forms.Padding(3);
            this.add_tab.Size = new System.Drawing.Size(495, 291);
            this.add_tab.TabIndex = 1;
            this.add_tab.Text = "          Add Slot   ";
            this.add_tab.Click += new System.EventHandler(this.add_tab_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestSlotToolStripMenuItem,
            this.customerSlotToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guestSlotToolStripMenuItem
            // 
            this.guestSlotToolStripMenuItem.Name = "guestSlotToolStripMenuItem";
            this.guestSlotToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.guestSlotToolStripMenuItem.Text = "Guest Slot";
            this.guestSlotToolStripMenuItem.Click += new System.EventHandler(this.guestSlotToolStripMenuItem_Click);
            // 
            // customerSlotToolStripMenuItem
            // 
            this.customerSlotToolStripMenuItem.Name = "customerSlotToolStripMenuItem";
            this.customerSlotToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.customerSlotToolStripMenuItem.Text = "Customer Slot";
            this.customerSlotToolStripMenuItem.Click += new System.EventHandler(this.customerSlotToolStripMenuItem_Click);
            // 
            // pnl_customer
            // 
            this.pnl_customer.AutoSize = true;
            this.pnl_customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_customer.Controls.Add(this.ui_datePickercus);
            this.pnl_customer.Controls.Add(this.label8);
            this.pnl_customer.Controls.Add(this.lbl_slot2);
            this.pnl_customer.Controls.Add(this.ui_idcus);
            this.pnl_customer.Controls.Add(this.ui_hourscus);
            this.pnl_customer.Controls.Add(this.btn_addcus);
            this.pnl_customer.Controls.Add(this.label4);
            this.pnl_customer.Controls.Add(this.label7);
            this.pnl_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_customer.Location = new System.Drawing.Point(3, 3);
            this.pnl_customer.Name = "pnl_customer";
            this.pnl_customer.Size = new System.Drawing.Size(489, 285);
            this.pnl_customer.TabIndex = 11;
            this.pnl_customer.Visible = false;
            // 
            // ui_datePickercus
            // 
            this.ui_datePickercus.Location = new System.Drawing.Point(112, 153);
            this.ui_datePickercus.Name = "ui_datePickercus";
            this.ui_datePickercus.Size = new System.Drawing.Size(272, 27);
            this.ui_datePickercus.TabIndex = 16;
            this.ui_datePickercus.Value = new System.DateTime(2020, 10, 7, 20, 12, 31, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date:";
            // 
            // lbl_slot2
            // 
            this.lbl_slot2.AutoSize = true;
            this.lbl_slot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slot2.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_slot2.Location = new System.Drawing.Point(33, 199);
            this.lbl_slot2.Name = "lbl_slot2";
            this.lbl_slot2.Size = new System.Drawing.Size(0, 13);
            this.lbl_slot2.TabIndex = 14;
            // 
            // ui_idcus
            // 
            this.ui_idcus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_idcus.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_idcus.FormattingEnabled = true;
            this.ui_idcus.Location = new System.Drawing.Point(234, 39);
            this.ui_idcus.Name = "ui_idcus";
            this.ui_idcus.Size = new System.Drawing.Size(150, 27);
            this.ui_idcus.TabIndex = 13;
            // 
            // ui_hourscus
            // 
            this.ui_hourscus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_hourscus.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_hourscus.FormattingEnabled = true;
            this.ui_hourscus.Location = new System.Drawing.Point(237, 96);
            this.ui_hourscus.Name = "ui_hourscus";
            this.ui_hourscus.Size = new System.Drawing.Size(150, 27);
            this.ui_hourscus.TabIndex = 12;
            this.ui_hourscus.SelectedIndexChanged += new System.EventHandler(this.ui_hours2_SelectedIndexChanged);
            // 
            // btn_addcus
            // 
            this.btn_addcus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_addcus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addcus.Location = new System.Drawing.Point(299, 199);
            this.btn_addcus.Name = "btn_addcus";
            this.btn_addcus.Size = new System.Drawing.Size(85, 35);
            this.btn_addcus.TabIndex = 10;
            this.btn_addcus.Text = "Add";
            this.btn_addcus.UseVisualStyleBackColor = false;
            this.btn_addcus.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "ID:";
            // 
            // pnl_guest
            // 
            this.pnl_guest.Controls.Add(this.ui_datePickercb);
            this.pnl_guest.Controls.Add(this.label5);
            this.pnl_guest.Controls.Add(this.lbl_slot1);
            this.pnl_guest.Controls.Add(this.ui_hourscb);
            this.pnl_guest.Controls.Add(this.ui_gamecb);
            this.pnl_guest.Controls.Add(this.btn_add2);
            this.pnl_guest.Controls.Add(this.label3);
            this.pnl_guest.Controls.Add(this.label2);
            this.pnl_guest.Controls.Add(this.label1);
            this.pnl_guest.Controls.Add(this.ui_namecb);
            this.pnl_guest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_guest.Location = new System.Drawing.Point(3, 3);
            this.pnl_guest.Name = "pnl_guest";
            this.pnl_guest.Size = new System.Drawing.Size(489, 285);
            this.pnl_guest.TabIndex = 4;
            this.pnl_guest.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ui_datePickercb
            // 
            this.ui_datePickercb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_datePickercb.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.ui_datePickercb.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_datePickercb.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.ui_datePickercb.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.ui_datePickercb.Location = new System.Drawing.Point(129, 185);
            this.ui_datePickercb.Name = "ui_datePickercb";
            this.ui_datePickercb.Size = new System.Drawing.Size(258, 27);
            this.ui_datePickercb.TabIndex = 14;
            this.ui_datePickercb.Value = new System.DateTime(2020, 10, 7, 20, 12, 31, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date:";
            // 
            // lbl_slot1
            // 
            this.lbl_slot1.AccessibleName = "lbl_slot1";
            this.lbl_slot1.AutoSize = true;
            this.lbl_slot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slot1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_slot1.Location = new System.Drawing.Point(31, 222);
            this.lbl_slot1.Name = "lbl_slot1";
            this.lbl_slot1.Size = new System.Drawing.Size(0, 13);
            this.lbl_slot1.TabIndex = 12;
            // 
            // ui_hourscb
            // 
            this.ui_hourscb.AccessibleName = "lbl_slot2";
            this.ui_hourscb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_hourscb.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_hourscb.FormattingEnabled = true;
            this.ui_hourscb.Location = new System.Drawing.Point(237, 151);
            this.ui_hourscb.Name = "ui_hourscb";
            this.ui_hourscb.Size = new System.Drawing.Size(150, 27);
            this.ui_hourscb.TabIndex = 11;
            // 
            // ui_gamecb
            // 
            this.ui_gamecb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_gamecb.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_gamecb.FormattingEnabled = true;
            this.ui_gamecb.Location = new System.Drawing.Point(237, 99);
            this.ui_gamecb.Name = "ui_gamecb";
            this.ui_gamecb.Size = new System.Drawing.Size(150, 27);
            this.ui_gamecb.TabIndex = 2;
            // 
            // btn_add2
            // 
            this.btn_add2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_add2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add2.Location = new System.Drawing.Point(302, 226);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(85, 35);
            this.btn_add2.TabIndex = 10;
            this.btn_add2.Text = "Add";
            this.btn_add2.UseVisualStyleBackColor = false;
            this.btn_add2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Game:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // ui_namecb
            // 
            this.ui_namecb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_namecb.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_namecb.Location = new System.Drawing.Point(237, 47);
            this.ui_namecb.Name = "ui_namecb";
            this.ui_namecb.Size = new System.Drawing.Size(150, 27);
            this.ui_namecb.TabIndex = 0;
            this.ui_namecb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // remove_tab
            // 
            this.remove_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_tab.Controls.Add(this.panel4);
            this.remove_tab.Location = new System.Drawing.Point(4, 28);
            this.remove_tab.Name = "remove_tab";
            this.remove_tab.Padding = new System.Windows.Forms.Padding(3);
            this.remove_tab.Size = new System.Drawing.Size(495, 291);
            this.remove_tab.TabIndex = 2;
            this.remove_tab.Text = "          Remove Slot";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ui_selectedid);
            this.panel4.Controls.Add(this.lbl_slot3);
            this.panel4.Controls.Add(this.btn_remove);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 285);
            this.panel4.TabIndex = 5;
            // 
            // ui_selectedid
            // 
            this.ui_selectedid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_selectedid.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_selectedid.FormattingEnabled = true;
            this.ui_selectedid.Location = new System.Drawing.Point(177, 39);
            this.ui_selectedid.Name = "ui_selectedid";
            this.ui_selectedid.Size = new System.Drawing.Size(150, 27);
            this.ui_selectedid.Sorted = true;
            this.ui_selectedid.TabIndex = 15;
            // 
            // lbl_slot3
            // 
            this.lbl_slot3.AutoSize = true;
            this.lbl_slot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slot3.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_slot3.Location = new System.Drawing.Point(27, 88);
            this.lbl_slot3.Name = "lbl_slot3";
            this.lbl_slot3.Size = new System.Drawing.Size(0, 13);
            this.lbl_slot3.TabIndex = 14;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Location = new System.Drawing.Point(242, 109);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(85, 35);
            this.btn_remove.TabIndex = 10;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gv_slot);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 423);
            this.panel2.TabIndex = 5;
            // 
            // gv_slot
            // 
            this.gv_slot.AllowUserToAddRows = false;
            this.gv_slot.AllowUserToDeleteRows = false;
            this.gv_slot.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_slot.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gv_slot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_slot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gv_slot.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_slot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gv_slot.ColumnHeadersHeight = 35;
            this.gv_slot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_slot.DefaultCellStyle = dataGridViewCellStyle15;
            this.gv_slot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_slot.EnableHeadersVisualStyles = false;
            this.gv_slot.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gv_slot.Location = new System.Drawing.Point(0, 100);
            this.gv_slot.MultiSelect = false;
            this.gv_slot.Name = "gv_slot";
            this.gv_slot.ReadOnly = true;
            this.gv_slot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_slot.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gv_slot.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gv_slot.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gv_slot.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gv_slot.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_slot.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.gv_slot.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.gv_slot.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_slot.Size = new System.Drawing.Size(552, 323);
            this.gv_slot.TabIndex = 5;
            this.gv_slot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_slot_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 100);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "Customize Slots";
            // 
            // SlotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1061, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SlotUI";
            this.Text = "SlotUI";
            this.tabControl1.ResumeLayout(false);
            this.add_tab.ResumeLayout(false);
            this.add_tab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_customer.ResumeLayout(false);
            this.pnl_customer.PerformLayout();
            this.pnl_guest.ResumeLayout(false);
            this.pnl_guest.PerformLayout();
            this.remove_tab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_slot)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage add_tab;
        private System.Windows.Forms.Panel pnl_guest;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ui_namecb;
        private System.Windows.Forms.TabPage remove_tab;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_customer;
        private System.Windows.Forms.Button btn_addcus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guestSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerSlotToolStripMenuItem;
        private System.Windows.Forms.ComboBox ui_hourscb;
        private System.Windows.Forms.Label lbl_slot1;
        private System.Windows.Forms.ComboBox ui_gamecb;
        private System.Windows.Forms.ComboBox ui_hourscus;
        private System.Windows.Forms.ComboBox ui_idcus;
        private System.Windows.Forms.Label lbl_slot2;
        private System.Windows.Forms.Label lbl_slot3;
        private System.Windows.Forms.DateTimePicker ui_datePickercb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ui_datePickercus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gv_slot;
        private System.Windows.Forms.ComboBox ui_selectedid;
        private System.Windows.Forms.Label label6;
    }
}