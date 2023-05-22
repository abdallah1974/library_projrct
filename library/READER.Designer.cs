
namespace library
{
    partial class READER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(READER));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Reader = new System.Windows.Forms.Label();
            this.books_l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReaderBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ReaderGrid = new Guna.UI.WinForms.GunaDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ReaderName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReaderPhone = new System.Windows.Forms.TextBox();
            this.ReadderAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReaderSSN = new System.Windows.Forms.TextBox();
            this.l_Name = new System.Windows.Forms.Label();
            this.ReaderDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ReaderEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.READER_ADD = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 520);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 491);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "V1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label3.Location = new System.Drawing.Point(54, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ORDERS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Reader
            // 
            this.label_Reader.AutoSize = true;
            this.label_Reader.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label_Reader.Location = new System.Drawing.Point(54, 241);
            this.label_Reader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Reader.Name = "label_Reader";
            this.label_Reader.Size = new System.Drawing.Size(80, 22);
            this.label_Reader.TabIndex = 4;
            this.label_Reader.Text = "READER";
            this.label_Reader.Click += new System.EventHandler(this.label_Reader_Click);
            // 
            // books_l
            // 
            this.books_l.AutoSize = true;
            this.books_l.Font = new System.Drawing.Font("Montserrat", 12F);
            this.books_l.Location = new System.Drawing.Point(54, 171);
            this.books_l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.books_l.Name = "books_l";
            this.books_l.Size = new System.Drawing.Size(69, 22);
            this.books_l.TabIndex = 2;
            this.books_l.Text = "BOOKS";
            this.books_l.Click += new System.EventHandler(this.books_l_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "University Library";
            // 
            // ReaderBirth
            // 
            this.ReaderBirth.BackColor = System.Drawing.Color.SeaGreen;
            this.ReaderBirth.BorderRadius = 0;
            this.ReaderBirth.ForeColor = System.Drawing.Color.White;
            this.ReaderBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ReaderBirth.FormatCustom = null;
            this.ReaderBirth.Location = new System.Drawing.Point(743, 72);
            this.ReaderBirth.Name = "ReaderBirth";
            this.ReaderBirth.Size = new System.Drawing.Size(141, 24);
            this.ReaderBirth.TabIndex = 47;
            this.ReaderBirth.Value = new System.DateTime(2023, 5, 20, 3, 32, 27, 251);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 33);
            this.label4.TabIndex = 36;
            this.label4.Text = "READER";
            // 
            // ReaderGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ReaderGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ReaderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReaderGrid.BackgroundColor = System.Drawing.Color.White;
            this.ReaderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReaderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReaderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReaderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ReaderGrid.ColumnHeadersHeight = 26;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReaderGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.ReaderGrid.EnableHeadersVisualStyles = false;
            this.ReaderGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReaderGrid.Location = new System.Drawing.Point(176, 175);
            this.ReaderGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ReaderGrid.Name = "ReaderGrid";
            this.ReaderGrid.RowHeadersVisible = false;
            this.ReaderGrid.RowHeadersWidth = 51;
            this.ReaderGrid.RowTemplate.Height = 24;
            this.ReaderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReaderGrid.Size = new System.Drawing.Size(722, 319);
            this.ReaderGrid.TabIndex = 35;
            this.ReaderGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ReaderGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReaderGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReaderGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReaderGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReaderGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReaderGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReaderGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReaderGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReaderGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReaderGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReaderGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReaderGrid.ThemeStyle.HeaderStyle.Height = 26;
            this.ReaderGrid.ThemeStyle.ReadOnly = false;
            this.ReaderGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReaderGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReaderGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReaderGrid.ThemeStyle.RowsStyle.Height = 24;
            this.ReaderGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReaderGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReaderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReaderGrid_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(739, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Birth Date";
            // 
            // ReaderName
            // 
            this.ReaderName.BackColor = System.Drawing.SystemColors.Window;
            this.ReaderName.Location = new System.Drawing.Point(209, 76);
            this.ReaderName.Margin = new System.Windows.Forms.Padding(2);
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.Size = new System.Drawing.Size(111, 20);
            this.ReaderName.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(205, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(599, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 42;
            this.label7.Text = "Address";
            // 
            // ReaderPhone
            // 
            this.ReaderPhone.BackColor = System.Drawing.SystemColors.Window;
            this.ReaderPhone.Location = new System.Drawing.Point(470, 76);
            this.ReaderPhone.Margin = new System.Windows.Forms.Padding(2);
            this.ReaderPhone.Name = "ReaderPhone";
            this.ReaderPhone.Size = new System.Drawing.Size(116, 20);
            this.ReaderPhone.TabIndex = 39;
            // 
            // ReadderAddress
            // 
            this.ReadderAddress.BackColor = System.Drawing.SystemColors.Window;
            this.ReadderAddress.Location = new System.Drawing.Point(603, 76);
            this.ReadderAddress.Margin = new System.Windows.Forms.Padding(2);
            this.ReadderAddress.Name = "ReadderAddress";
            this.ReadderAddress.Size = new System.Drawing.Size(129, 20);
            this.ReadderAddress.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(466, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Phone";
            // 
            // ReaderSSN
            // 
            this.ReaderSSN.BackColor = System.Drawing.SystemColors.Window;
            this.ReaderSSN.Location = new System.Drawing.Point(340, 76);
            this.ReaderSSN.Margin = new System.Windows.Forms.Padding(2);
            this.ReaderSSN.Name = "ReaderSSN";
            this.ReaderSSN.Size = new System.Drawing.Size(111, 20);
            this.ReaderSSN.TabIndex = 48;
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name.ForeColor = System.Drawing.Color.Black;
            this.l_Name.Location = new System.Drawing.Point(336, 48);
            this.l_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(43, 21);
            this.l_Name.TabIndex = 49;
            this.l_Name.Text = "SSN";
            // 
            // ReaderDelete
            // 
            this.ReaderDelete.ActiveBorderThickness = 1;
            this.ReaderDelete.ActiveCornerRadius = 20;
            this.ReaderDelete.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.ReaderDelete.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.ReaderDelete.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.ReaderDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReaderDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReaderDelete.BackgroundImage")));
            this.ReaderDelete.ButtonText = "DELETE";
            this.ReaderDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReaderDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.ReaderDelete.IdleBorderThickness = 1;
            this.ReaderDelete.IdleCornerRadius = 20;
            this.ReaderDelete.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.ReaderDelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ReaderDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ReaderDelete.Location = new System.Drawing.Point(644, 118);
            this.ReaderDelete.Margin = new System.Windows.Forms.Padding(4);
            this.ReaderDelete.Name = "ReaderDelete";
            this.ReaderDelete.Size = new System.Drawing.Size(136, 33);
            this.ReaderDelete.TabIndex = 46;
            this.ReaderDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReaderDelete.Click += new System.EventHandler(this.ReaderDelete_Click);
            // 
            // ReaderEdit
            // 
            this.ReaderEdit.ActiveBorderThickness = 1;
            this.ReaderEdit.ActiveCornerRadius = 20;
            this.ReaderEdit.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.ReaderEdit.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.ReaderEdit.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.ReaderEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReaderEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReaderEdit.BackgroundImage")));
            this.ReaderEdit.ButtonText = "EDIT";
            this.ReaderEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReaderEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.ReaderEdit.IdleBorderThickness = 1;
            this.ReaderEdit.IdleCornerRadius = 20;
            this.ReaderEdit.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.ReaderEdit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ReaderEdit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ReaderEdit.Location = new System.Drawing.Point(450, 118);
            this.ReaderEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ReaderEdit.Name = "ReaderEdit";
            this.ReaderEdit.Size = new System.Drawing.Size(136, 33);
            this.ReaderEdit.TabIndex = 45;
            this.ReaderEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReaderEdit.Click += new System.EventHandler(this.ReaderEdit_Click);
            // 
            // READER_ADD
            // 
            this.READER_ADD.ActiveBorderThickness = 1;
            this.READER_ADD.ActiveCornerRadius = 20;
            this.READER_ADD.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.READER_ADD.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.READER_ADD.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.READER_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.READER_ADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("READER_ADD.BackgroundImage")));
            this.READER_ADD.ButtonText = "ADD";
            this.READER_ADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.READER_ADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READER_ADD.ForeColor = System.Drawing.Color.SeaGreen;
            this.READER_ADD.IdleBorderThickness = 1;
            this.READER_ADD.IdleCornerRadius = 20;
            this.READER_ADD.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.READER_ADD.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.READER_ADD.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.READER_ADD.Location = new System.Drawing.Point(251, 118);
            this.READER_ADD.Margin = new System.Windows.Forms.Padding(4);
            this.READER_ADD.Name = "READER_ADD";
            this.READER_ADD.Size = new System.Drawing.Size(136, 33);
            this.READER_ADD.TabIndex = 44;
            this.READER_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.READER_ADD.Click += new System.EventHandler(this.READER_ADD_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::library.Properties.Resources.bill;
            this.pictureBox4.Location = new System.Drawing.Point(13, 310);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::library.Properties.Resources.man_in_suit_and_tie;
            this.pictureBox3.Location = new System.Drawing.Point(13, 232);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::library.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(13, 162);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library.Properties.Resources.library_uni;
            this.pictureBox1.Location = new System.Drawing.Point(48, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // READER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(915, 520);
            this.ControlBox = false;
            this.Controls.Add(this.ReaderSSN);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.ReaderBirth);
            this.Controls.Add(this.ReaderDelete);
            this.Controls.Add(this.ReaderEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.READER_ADD);
            this.Controls.Add(this.ReaderGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ReaderName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReaderPhone);
            this.Controls.Add(this.ReadderAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "READER";
            this.ShowIcon = false;
            this.Text = "READER";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Bunifu.Framework.UI.BunifuDatepicker ReaderBirth;
        private Bunifu.Framework.UI.BunifuThinButton2 ReaderDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 ReaderEdit;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 READER_ADD;
        private Guna.UI.WinForms.GunaDataGridView ReaderGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReaderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ReaderPhone;
        private System.Windows.Forms.TextBox ReadderAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReaderSSN;
        private System.Windows.Forms.Label l_Name;
    }
}