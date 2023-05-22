
namespace library
{
    partial class readerSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(readerSignIn));
            this.PasswordLogin_Reader = new System.Windows.Forms.TextBox();
            this.IDLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SingInLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginSignin = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLogin_Reader
            // 
            this.PasswordLogin_Reader.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordLogin_Reader.Location = new System.Drawing.Point(95, 292);
            this.PasswordLogin_Reader.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordLogin_Reader.Name = "PasswordLogin_Reader";
            this.PasswordLogin_Reader.Size = new System.Drawing.Size(129, 20);
            this.PasswordLogin_Reader.TabIndex = 38;
            // 
            // IDLogin
            // 
            this.IDLogin.BackColor = System.Drawing.SystemColors.Window;
            this.IDLogin.Location = new System.Drawing.Point(95, 229);
            this.IDLogin.Margin = new System.Windows.Forms.Padding(2);
            this.IDLogin.Name = "IDLogin";
            this.IDLogin.Size = new System.Drawing.Size(129, 20);
            this.IDLogin.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "SSN";
            // 
            // SingInLabel
            // 
            this.SingInLabel.AutoSize = true;
            this.SingInLabel.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingInLabel.ForeColor = System.Drawing.Color.Black;
            this.SingInLabel.Location = new System.Drawing.Point(91, 102);
            this.SingInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SingInLabel.Name = "SingInLabel";
            this.SingInLabel.Size = new System.Drawing.Size(78, 21);
            this.SingInLabel.TabIndex = 34;
            this.SingInLabel.Text = "SIGN-IN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library.Properties.Resources.watermelon;
            this.pictureBox1.Location = new System.Drawing.Point(95, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // LoginSignin
            // 
            this.LoginSignin.ActiveBorderThickness = 1;
            this.LoginSignin.ActiveCornerRadius = 20;
            this.LoginSignin.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.LoginSignin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginSignin.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.LoginSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginSignin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginSignin.BackgroundImage")));
            this.LoginSignin.ButtonText = "LOG-IN";
            this.LoginSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginSignin.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSignin.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginSignin.IdleBorderThickness = 1;
            this.LoginSignin.IdleCornerRadius = 20;
            this.LoginSignin.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.LoginSignin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.LoginSignin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.LoginSignin.Location = new System.Drawing.Point(64, 364);
            this.LoginSignin.Margin = new System.Windows.Forms.Padding(4);
            this.LoginSignin.Name = "LoginSignin";
            this.LoginSignin.Size = new System.Drawing.Size(122, 30);
            this.LoginSignin.TabIndex = 39;
            this.LoginSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readerSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(254, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginSignin);
            this.Controls.Add(this.PasswordLogin_Reader);
            this.Controls.Add(this.IDLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SingInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "readerSignIn";
            this.Text = "readerSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginSignin;
        private System.Windows.Forms.TextBox PasswordLogin_Reader;
        private System.Windows.Forms.TextBox IDLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SingInLabel;
    }
}