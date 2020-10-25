namespace Dynamic_Gamming
{
    partial class GamesUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gv_game = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.add_tab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ui_genre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ui_mulno = new System.Windows.Forms.RadioButton();
            this.ui_mulyes = new System.Windows.Forms.RadioButton();
            this.ui_releaseyr = new System.Windows.Forms.ComboBox();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_name = new System.Windows.Forms.TextBox();
            this.remove_tab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.ui_id = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_game)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.add_tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.remove_tab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gv_game);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 424);
            this.panel2.TabIndex = 4;
            // 
            // gv_game
            // 
            this.gv_game.AllowUserToAddRows = false;
            this.gv_game.AllowUserToDeleteRows = false;
            this.gv_game.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_game.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.gv_game.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_game.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gv_game.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_game.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gv_game.ColumnHeadersHeight = 35;
            this.gv_game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_game.DefaultCellStyle = dataGridViewCellStyle19;
            this.gv_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_game.EnableHeadersVisualStyles = false;
            this.gv_game.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gv_game.Location = new System.Drawing.Point(0, 100);
            this.gv_game.MultiSelect = false;
            this.gv_game.Name = "gv_game";
            this.gv_game.ReadOnly = true;
            this.gv_game.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_game.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.gv_game.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gv_game.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gv_game.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gv_game.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_game.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.gv_game.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gold;
            this.gv_game.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_game.Size = new System.Drawing.Size(552, 324);
            this.gv_game.TabIndex = 5;
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
            this.label6.Size = new System.Drawing.Size(252, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customize Games";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.add_tab);
            this.tabControl1.Controls.Add(this.remove_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(552, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 323);
            this.tabControl1.TabIndex = 5;
            // 
            // add_tab
            // 
            this.add_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_tab.Controls.Add(this.panel1);
            this.add_tab.Location = new System.Drawing.Point(4, 28);
            this.add_tab.Name = "add_tab";
            this.add_tab.Padding = new System.Windows.Forms.Padding(3);
            this.add_tab.Size = new System.Drawing.Size(511, 291);
            this.add_tab.TabIndex = 1;
            this.add_tab.Text = "Add Game";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ui_genre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ui_mulno);
            this.panel1.Controls.Add(this.ui_mulyes);
            this.panel1.Controls.Add(this.ui_releaseyr);
            this.panel1.Controls.Add(this.lbl_msg);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ui_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 285);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ui_genre
            // 
            this.ui_genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_genre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_genre.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_genre.FormattingEnabled = true;
            this.ui_genre.Location = new System.Drawing.Point(243, 81);
            this.ui_genre.Name = "ui_genre";
            this.ui_genre.Size = new System.Drawing.Size(150, 27);
            this.ui_genre.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Genre:";
            // 
            // ui_mulno
            // 
            this.ui_mulno.AutoSize = true;
            this.ui_mulno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_mulno.Location = new System.Drawing.Point(319, 158);
            this.ui_mulno.Name = "ui_mulno";
            this.ui_mulno.Size = new System.Drawing.Size(45, 23);
            this.ui_mulno.TabIndex = 17;
            this.ui_mulno.TabStop = true;
            this.ui_mulno.Text = "No";
            this.ui_mulno.UseVisualStyleBackColor = true;
            // 
            // ui_mulyes
            // 
            this.ui_mulyes.AutoSize = true;
            this.ui_mulyes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_mulyes.Location = new System.Drawing.Point(243, 158);
            this.ui_mulyes.Name = "ui_mulyes";
            this.ui_mulyes.Size = new System.Drawing.Size(49, 23);
            this.ui_mulyes.TabIndex = 16;
            this.ui_mulyes.TabStop = true;
            this.ui_mulyes.Text = "Yes";
            this.ui_mulyes.UseVisualStyleBackColor = true;
            // 
            // ui_releaseyr
            // 
            this.ui_releaseyr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_releaseyr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_releaseyr.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_releaseyr.FormattingEnabled = true;
            this.ui_releaseyr.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011"});
            this.ui_releaseyr.Location = new System.Drawing.Point(243, 118);
            this.ui_releaseyr.Name = "ui_releaseyr";
            this.ui_releaseyr.Size = new System.Drawing.Size(150, 27);
            this.ui_releaseyr.TabIndex = 15;
            this.ui_releaseyr.SelectedIndexChanged += new System.EventHandler(this.ui_id_SelectedIndexChanged);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_msg.Location = new System.Drawing.Point(27, 185);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 13);
            this.lbl_msg.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Multiplayer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Release Year: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // ui_name
            // 
            this.ui_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_name.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_name.Location = new System.Drawing.Point(243, 46);
            this.ui_name.Name = "ui_name";
            this.ui_name.Size = new System.Drawing.Size(150, 27);
            this.ui_name.TabIndex = 0;
            this.ui_name.TextChanged += new System.EventHandler(this.lbl_name_TextChanged);
            // 
            // remove_tab
            // 
            this.remove_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_tab.Controls.Add(this.panel4);
            this.remove_tab.Location = new System.Drawing.Point(4, 28);
            this.remove_tab.Name = "remove_tab";
            this.remove_tab.Padding = new System.Windows.Forms.Padding(3);
            this.remove_tab.Size = new System.Drawing.Size(494, 291);
            this.remove_tab.TabIndex = 2;
            this.remove_tab.Text = "Remove Game";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_error);
            this.panel4.Controls.Add(this.ui_id);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 285);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_error.Location = new System.Drawing.Point(27, 91);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 17;
            // 
            // ui_id
            // 
            this.ui_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ui_id.ForeColor = System.Drawing.Color.Gainsboro;
            this.ui_id.FormattingEnabled = true;
            this.ui_id.Location = new System.Drawing.Point(172, 36);
            this.ui_id.Name = "ui_id";
            this.ui_id.Size = new System.Drawing.Size(150, 27);
            this.ui_id.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(237, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Selesct Game:";
            // 
            // GamesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1071, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "GamesUI";
            this.Text = "GamesUI";
            this.Load += new System.EventHandler(this.GamesUI_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_game)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.add_tab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.remove_tab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage add_tab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ui_name;
        private System.Windows.Forms.TabPage remove_tab;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.ComboBox ui_releaseyr;
        private System.Windows.Forms.RadioButton ui_mulno;
        private System.Windows.Forms.RadioButton ui_mulyes;
        private System.Windows.Forms.ComboBox ui_id;
        private System.Windows.Forms.ComboBox ui_genre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gv_game;
    }
}