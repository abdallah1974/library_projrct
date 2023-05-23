
namespace library
{
    partial class order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            this.BOOKNAME = new System.Windows.Forms.TextBox();
            this.l_Name = new System.Windows.Forms.Label();
            this.BORROWDATE = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.READERSSN = new System.Windows.Forms.TextBox();
            this.OrderGrid = new Guna.UI.WinForms.GunaDataGridView();
            this.OrderDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OrderEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ORDER_ADD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_Reader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.books_l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BOOKNAME
            // 
            this.BOOKNAME.BackColor = System.Drawing.SystemColors.Window;
            this.BOOKNAME.Location = new System.Drawing.Point(578, 86);
            this.BOOKNAME.Margin = new System.Windows.Forms.Padding(2);
            this.BOOKNAME.Name = "BOOKNAME";
            this.BOOKNAME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BOOKNAME.Size = new System.Drawing.Size(163, 20);
            this.BOOKNAME.TabIndex = 63;
            this.BOOKNAME.TextChanged += new System.EventHandler(this.ReaderSSN_TextChanged);
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name.ForeColor = System.Drawing.Color.Black;
            this.l_Name.Location = new System.Drawing.Point(602, 58);
            this.l_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(107, 21);
            this.l_Name.TabIndex = 64;
            this.l_Name.Text = "Book Name";
            this.l_Name.Click += new System.EventHandler(this.l_Name_Click);
            // 
            // BORROWDATE
            // 
            this.BORROWDATE.BackColor = System.Drawing.Color.SeaGreen;
            this.BORROWDATE.BorderRadius = 0;
            this.BORROWDATE.ForeColor = System.Drawing.Color.White;
            this.BORROWDATE.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BORROWDATE.FormatCustom = null;
            this.BORROWDATE.Location = new System.Drawing.Point(780, 86);
            this.BORROWDATE.Name = "BORROWDATE";
            this.BORROWDATE.Size = new System.Drawing.Size(170, 24);
            this.BORROWDATE.TabIndex = 62;
            this.BORROWDATE.Value = new System.DateTime(2023, 5, 20, 3, 32, 27, 251);
            this.BORROWDATE.onValueChanged += new System.EventHandler(this.ReaderBirth_onValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 33);
            this.label4.TabIndex = 51;
            this.label4.Text = "ORDERDS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(795, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 21);
            this.label8.TabIndex = 58;
            this.label8.Text = "Borrowing Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(383, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Reader SSN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(602, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 55;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // READERSSN
            // 
            this.READERSSN.BackColor = System.Drawing.SystemColors.Window;
            this.READERSSN.Location = new System.Drawing.Point(378, 86);
            this.READERSSN.Margin = new System.Windows.Forms.Padding(2);
            this.READERSSN.Name = "READERSSN";
            this.READERSSN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.READERSSN.Size = new System.Drawing.Size(163, 20);
            this.READERSSN.TabIndex = 65;
            // 
            // OrderGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.OrderGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGrid.BackgroundColor = System.Drawing.Color.White;
            this.OrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderGrid.ColumnHeadersHeight = 26;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrderGrid.EnableHeadersVisualStyles = false;
            this.OrderGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGrid.Location = new System.Drawing.Point(231, 189);
            this.OrderGrid.Margin = new System.Windows.Forms.Padding(2);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RowHeadersVisible = false;
            this.OrderGrid.RowHeadersWidth = 51;
            this.OrderGrid.RowTemplate.Height = 24;
            this.OrderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGrid.Size = new System.Drawing.Size(962, 393);
            this.OrderGrid.TabIndex = 67;
            this.OrderGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.OrderGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OrderGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderGrid.ThemeStyle.HeaderStyle.Height = 26;
            this.OrderGrid.ThemeStyle.ReadOnly = false;
            this.OrderGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderGrid.ThemeStyle.RowsStyle.Height = 24;
            this.OrderGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellContentClick);
            // 
            // OrderDelete
            // 
            this.OrderDelete.ActiveBorderThickness = 1;
            this.OrderDelete.ActiveCornerRadius = 20;
            this.OrderDelete.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.OrderDelete.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.OrderDelete.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.OrderDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OrderDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderDelete.BackgroundImage")));
            this.OrderDelete.ButtonText = "DELETE";
            this.OrderDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.OrderDelete.IdleBorderThickness = 1;
            this.OrderDelete.IdleCornerRadius = 20;
            this.OrderDelete.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.OrderDelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OrderDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OrderDelete.Location = new System.Drawing.Point(799, 128);
            this.OrderDelete.Margin = new System.Windows.Forms.Padding(4);
            this.OrderDelete.Name = "OrderDelete";
            this.OrderDelete.Size = new System.Drawing.Size(136, 33);
            this.OrderDelete.TabIndex = 69;
            this.OrderDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrderDelete.Click += new System.EventHandler(this.OrderDelete_Click);
            // 
            // OrderEdit
            // 
            this.OrderEdit.ActiveBorderThickness = 1;
            this.OrderEdit.ActiveCornerRadius = 20;
            this.OrderEdit.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.OrderEdit.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.OrderEdit.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.OrderEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OrderEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderEdit.BackgroundImage")));
            this.OrderEdit.ButtonText = "EDIT";
            this.OrderEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.OrderEdit.IdleBorderThickness = 1;
            this.OrderEdit.IdleCornerRadius = 20;
            this.OrderEdit.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.OrderEdit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OrderEdit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OrderEdit.Location = new System.Drawing.Point(573, 128);
            this.OrderEdit.Margin = new System.Windows.Forms.Padding(4);
            this.OrderEdit.Name = "OrderEdit";
            this.OrderEdit.Size = new System.Drawing.Size(136, 33);
            this.OrderEdit.TabIndex = 68;
            this.OrderEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrderEdit.Click += new System.EventHandler(this.OrderEdit_Click);
            // 
            // ORDER_ADD
            // 
            this.ORDER_ADD.ActiveBorderThickness = 1;
            this.ORDER_ADD.ActiveCornerRadius = 20;
            this.ORDER_ADD.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.ORDER_ADD.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.ORDER_ADD.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.ORDER_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ORDER_ADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ORDER_ADD.BackgroundImage")));
            this.ORDER_ADD.ButtonText = "ADD";
            this.ORDER_ADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ORDER_ADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDER_ADD.ForeColor = System.Drawing.Color.SeaGreen;
            this.ORDER_ADD.IdleBorderThickness = 1;
            this.ORDER_ADD.IdleCornerRadius = 20;
            this.ORDER_ADD.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.ORDER_ADD.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ORDER_ADD.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ORDER_ADD.Location = new System.Drawing.Point(387, 128);
            this.ORDER_ADD.Margin = new System.Windows.Forms.Padding(4);
            this.ORDER_ADD.Name = "ORDER_ADD";
            this.ORDER_ADD.Size = new System.Drawing.Size(136, 33);
            this.ORDER_ADD.TabIndex = 66;
            this.ORDER_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ORDER_ADD.Click += new System.EventHandler(this.ORDER_ADD_Click);
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
            this.panel1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 640);
            this.panel1.TabIndex = 70;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ORDERS";
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
            // label_Reader
            // 
            this.label_Reader.AutoSize = true;
            this.label_Reader.Location = new System.Drawing.Point(72, 297);
            this.label_Reader.Name = "label_Reader";
            this.label_Reader.Size = new System.Drawing.Size(80, 22);
            this.label_Reader.TabIndex = 4;
            this.label_Reader.Text = "READER";
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
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "University Library";
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
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1220, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrderDelete);
            this.Controls.Add(this.OrderEdit);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.ORDER_ADD);
            this.Controls.Add(this.READERSSN);
            this.Controls.Add(this.BOOKNAME);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.BORROWDATE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "order";
            this.Text = "order";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BOOKNAME;
        private System.Windows.Forms.Label l_Name;
        private Bunifu.Framework.UI.BunifuDatepicker BORROWDATE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox READERSSN;
        private Bunifu.Framework.UI.BunifuThinButton2 ORDER_ADD;
        private Guna.UI.WinForms.GunaDataGridView OrderGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 OrderEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 OrderDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_Reader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label books_l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}