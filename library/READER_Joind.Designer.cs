﻿
namespace library
{
    partial class READER_Joind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(READER_Joind));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.books_l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BookTable = new Guna.UI.WinForms.GunaDataGridView();
            this.BOOKNAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BOOKSEARCH = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.books_l);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 640);
            this.panel1.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "University Library";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "BOOKS";
            // 
            // BookTable
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.BookTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.BookTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookTable.BackgroundColor = System.Drawing.Color.White;
            this.BookTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BookTable.ColumnHeadersHeight = 26;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.BookTable.EnableHeadersVisualStyles = false;
            this.BookTable.GridColor = System.Drawing.Color.White;
            this.BookTable.Location = new System.Drawing.Point(236, 199);
            this.BookTable.Name = "BookTable";
            this.BookTable.RowHeadersVisible = false;
            this.BookTable.RowHeadersWidth = 51;
            this.BookTable.RowTemplate.Height = 24;
            this.BookTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookTable.Size = new System.Drawing.Size(962, 393);
            this.BookTable.TabIndex = 11;
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
            // 
            // BOOKNAME
            // 
            this.BOOKNAME.BackColor = System.Drawing.SystemColors.Window;
            this.BOOKNAME.Location = new System.Drawing.Point(662, 118);
            this.BOOKNAME.Name = "BOOKNAME";
            this.BOOKNAME.Size = new System.Drawing.Size(182, 20);
            this.BOOKNAME.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label5.Location = new System.Drawing.Point(553, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Book name";
            // 
            // BOOKSEARCH
            // 
            this.BOOKSEARCH.ActiveBorderThickness = 1;
            this.BOOKSEARCH.ActiveCornerRadius = 20;
            this.BOOKSEARCH.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.BOOKSEARCH.ActiveForecolor = System.Drawing.Color.LightSalmon;
            this.BOOKSEARCH.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.BOOKSEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BOOKSEARCH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BOOKSEARCH.BackgroundImage")));
            this.BOOKSEARCH.ButtonText = "Search";
            this.BOOKSEARCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BOOKSEARCH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOOKSEARCH.ForeColor = System.Drawing.Color.SeaGreen;
            this.BOOKSEARCH.IdleBorderThickness = 1;
            this.BOOKSEARCH.IdleCornerRadius = 20;
            this.BOOKSEARCH.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.BOOKSEARCH.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BOOKSEARCH.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BOOKSEARCH.Location = new System.Drawing.Point(598, 150);
            this.BOOKSEARCH.Margin = new System.Windows.Forms.Padding(5);
            this.BOOKSEARCH.Name = "BOOKSEARCH";
            this.BOOKSEARCH.Size = new System.Drawing.Size(181, 41);
            this.BOOKSEARCH.TabIndex = 20;
            this.BOOKSEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BOOKSEARCH.Click += new System.EventHandler(this.BOOKSEARCH_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(70, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::library.Properties.Resources.bill;
            this.pictureBox4.Location = new System.Drawing.Point(16, 282);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "MY ORDERS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // READER_Joind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1220, 640);
            this.Controls.Add(this.BOOKSEARCH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BOOKNAME);
            this.Controls.Add(this.BookTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "READER_Joind";
            this.Text = "READER_Joind";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label books_l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDataGridView BookTable;
        private System.Windows.Forms.TextBox BOOKNAME;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 BOOKSEARCH;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
    }
}