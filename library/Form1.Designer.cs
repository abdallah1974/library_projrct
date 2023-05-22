
namespace library
{
    partial class books_tab
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books_tab));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Reader = new System.Windows.Forms.Label();
            this.books_l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.BookTable = new Guna.UI.WinForms.GunaDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BOOKNAME = new System.Windows.Forms.TextBox();
            this.NAMELABEL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BOOKAUTHOR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BOOKINSTOCK = new System.Windows.Forms.TextBox();
            this.BOOKCATEGORY = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BOOKDELETE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BOOKEDIT = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BOOKADD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = global::library.Properties.Settings.Default.elipse_radius;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label_Reader);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.books_l);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 640);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "V1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ORDERS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Reader
            // 
            this.label_Reader.AutoSize = true;
            this.label_Reader.Location = new System.Drawing.Point(72, 297);
            this.label_Reader.Name = "label_Reader";
            this.label_Reader.Size = new System.Drawing.Size(80, 22);
            this.label_Reader.TabIndex = 4;
            this.label_Reader.Text = "READER";
            this.label_Reader.Click += new System.EventHandler(this.label2_Click);
            // 
            // books_l
            // 
            this.books_l.AutoSize = true;
            this.books_l.Location = new System.Drawing.Point(72, 210);
            this.books_l.Name = "books_l";
            this.books_l.Size = new System.Drawing.Size(69, 22);
            this.books_l.TabIndex = 2;
            this.books_l.Text = "BOOKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "University Library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // BookTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BookTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookTable.BackgroundColor = System.Drawing.Color.White;
            this.BookTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BookTable.ColumnHeadersHeight = 26;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookTable.EnableHeadersVisualStyles = false;
            this.BookTable.GridColor = System.Drawing.Color.White;
            this.BookTable.Location = new System.Drawing.Point(233, 233);
            this.BookTable.Name = "BookTable";
            this.BookTable.RowHeadersVisible = false;
            this.BookTable.RowHeadersWidth = 51;
            this.BookTable.RowTemplate.Height = 24;
            this.BookTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookTable.Size = new System.Drawing.Size(962, 393);
            this.BookTable.TabIndex = 1;
            this.BookTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BookTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BookTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BookTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BookTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BookTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BookTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BookTable.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.BookTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BookTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookTable.ThemeStyle.HeaderStyle.Height = 26;
            this.BookTable.ThemeStyle.ReadOnly = false;
            this.BookTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BookTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookTable.ThemeStyle.RowsStyle.Height = 24;
            this.BookTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookTable_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "BOOKS";
            // 
            // BOOKNAME
            // 
            this.BOOKNAME.BackColor = System.Drawing.SystemColors.Window;
            this.BOOKNAME.Location = new System.Drawing.Point(344, 104);
            this.BOOKNAME.Name = "BOOKNAME";
            this.BOOKNAME.Size = new System.Drawing.Size(171, 27);
            this.BOOKNAME.TabIndex = 10;
            this.BOOKNAME.TextChanged += new System.EventHandler(this.BOOKNAME_TextChanged);
            // 
            // NAMELABEL
            // 
            this.NAMELABEL.AutoSize = true;
            this.NAMELABEL.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAMELABEL.ForeColor = System.Drawing.Color.Black;
            this.NAMELABEL.Location = new System.Drawing.Point(339, 75);
            this.NAMELABEL.Name = "NAMELABEL";
            this.NAMELABEL.Size = new System.Drawing.Size(107, 21);
            this.NAMELABEL.TabIndex = 11;
            this.NAMELABEL.Text = "Book Name";
            this.NAMELABEL.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(533, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Author";
            // 
            // BOOKAUTHOR
            // 
            this.BOOKAUTHOR.BackColor = System.Drawing.SystemColors.Window;
            this.BOOKAUTHOR.Location = new System.Drawing.Point(538, 104);
            this.BOOKAUTHOR.Name = "BOOKAUTHOR";
            this.BOOKAUTHOR.Size = new System.Drawing.Size(171, 27);
            this.BOOKAUTHOR.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(727, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "No.Books";
            // 
            // BOOKINSTOCK
            // 
            this.BOOKINSTOCK.BackColor = System.Drawing.SystemColors.Window;
            this.BOOKINSTOCK.Location = new System.Drawing.Point(732, 104);
            this.BOOKINSTOCK.Name = "BOOKINSTOCK";
            this.BOOKINSTOCK.Size = new System.Drawing.Size(171, 27);
            this.BOOKINSTOCK.TabIndex = 14;
            // 
            // BOOKCATEGORY
            // 
            this.BOOKCATEGORY.FormattingEnabled = true;
            this.BOOKCATEGORY.Items.AddRange(new object[] {
            "Thriller",
            "Political",
            "Crime",
            "Historical",
            "Comedy",
            "Fantasy",
            "Educational",
            "Other"});
            this.BOOKCATEGORY.Location = new System.Drawing.Point(924, 101);
            this.BOOKCATEGORY.Name = "BOOKCATEGORY";
            this.BOOKCATEGORY.Size = new System.Drawing.Size(121, 30);
            this.BOOKCATEGORY.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(919, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Category";
            // 
            // BOOKDELETE
            // 
            this.BOOKDELETE.ActiveBorderThickness = 1;
            this.BOOKDELETE.ActiveCornerRadius = 20;
            this.BOOKDELETE.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.BOOKDELETE.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.BOOKDELETE.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.BOOKDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BOOKDELETE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BOOKDELETE.BackgroundImage")));
            this.BOOKDELETE.ButtonText = "DELETE";
            this.BOOKDELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BOOKDELETE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOOKDELETE.ForeColor = System.Drawing.Color.SeaGreen;
            this.BOOKDELETE.IdleBorderThickness = 1;
            this.BOOKDELETE.IdleCornerRadius = 20;
            this.BOOKDELETE.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.BOOKDELETE.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BOOKDELETE.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BOOKDELETE.Location = new System.Drawing.Point(879, 155);
            this.BOOKDELETE.Margin = new System.Windows.Forms.Padding(5);
            this.BOOKDELETE.Name = "BOOKDELETE";
            this.BOOKDELETE.Size = new System.Drawing.Size(181, 41);
            this.BOOKDELETE.TabIndex = 20;
            this.BOOKDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BOOKDELETE.Click += new System.EventHandler(this.BOOKDELETE_Click);
            // 
            // BOOKEDIT
            // 
            this.BOOKEDIT.ActiveBorderThickness = 1;
            this.BOOKEDIT.ActiveCornerRadius = 20;
            this.BOOKEDIT.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.BOOKEDIT.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.BOOKEDIT.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.BOOKEDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BOOKEDIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BOOKEDIT.BackgroundImage")));
            this.BOOKEDIT.ButtonText = "EDIT";
            this.BOOKEDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BOOKEDIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOOKEDIT.ForeColor = System.Drawing.Color.SeaGreen;
            this.BOOKEDIT.IdleBorderThickness = 1;
            this.BOOKEDIT.IdleCornerRadius = 20;
            this.BOOKEDIT.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.BOOKEDIT.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BOOKEDIT.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BOOKEDIT.Location = new System.Drawing.Point(599, 155);
            this.BOOKEDIT.Margin = new System.Windows.Forms.Padding(5);
            this.BOOKEDIT.Name = "BOOKEDIT";
            this.BOOKEDIT.Size = new System.Drawing.Size(181, 41);
            this.BOOKEDIT.TabIndex = 19;
            this.BOOKEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BOOKEDIT.Click += new System.EventHandler(this.BOOKEDIT_Click);
            // 
            // BOOKADD
            // 
            this.BOOKADD.ActiveBorderThickness = 1;
            this.BOOKADD.ActiveCornerRadius = 20;
            this.BOOKADD.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.BOOKADD.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.BOOKADD.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.BOOKADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BOOKADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BOOKADD.BackgroundImage")));
            this.BOOKADD.ButtonText = "ADD";
            this.BOOKADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BOOKADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOOKADD.ForeColor = System.Drawing.Color.SeaGreen;
            this.BOOKADD.IdleBorderThickness = 1;
            this.BOOKADD.IdleCornerRadius = 20;
            this.BOOKADD.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.BOOKADD.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BOOKADD.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BOOKADD.Location = new System.Drawing.Point(334, 155);
            this.BOOKADD.Margin = new System.Windows.Forms.Padding(5);
            this.BOOKADD.Name = "BOOKADD";
            this.BOOKADD.Size = new System.Drawing.Size(181, 41);
            this.BOOKADD.TabIndex = 18;
            this.BOOKADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BOOKADD.Click += new System.EventHandler(this.BOOKADD_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::library.Properties.Resources.bill;
            this.pictureBox4.Location = new System.Drawing.Point(17, 381);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::library.Properties.Resources.man_in_suit_and_tie;
            this.pictureBox3.Location = new System.Drawing.Point(17, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::library.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(17, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library.Properties.Resources.library_uni;
            this.pictureBox1.Location = new System.Drawing.Point(64, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // books_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1220, 640);
            this.Controls.Add(this.BOOKDELETE);
            this.Controls.Add(this.BOOKEDIT);
            this.Controls.Add(this.BOOKADD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BOOKCATEGORY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BOOKINSTOCK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BOOKAUTHOR);
            this.Controls.Add(this.NAMELABEL);
            this.Controls.Add(this.BOOKNAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookTable);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "books_tab";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.label1_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label books_l;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_Reader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NAMELABEL;
        private System.Windows.Forms.TextBox BOOKNAME;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDataGridView BookTable;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BOOKAUTHOR;
        private Bunifu.Framework.UI.BunifuThinButton2 BOOKDELETE;
        private Bunifu.Framework.UI.BunifuThinButton2 BOOKEDIT;
        private Bunifu.Framework.UI.BunifuThinButton2 BOOKADD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BOOKCATEGORY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BOOKINSTOCK;
    }
}

