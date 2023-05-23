using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void ADMIN_REGIST_Click(object sender, EventArgs e)
        {
            librerian_register r = new librerian_register();
            this.Hide();
            r.Show();
        }

        private void Admin_signIn_Click(object sender, EventArgs e)
        {
            admin_signIN r = new admin_signIN();
            this.Hide();
            r.Show();
        }

        private void USER_UP_Click(object sender, EventArgs e)
        {
            ReaderSignUP r = new ReaderSignUP();
            this.Hide();
            r.Show();
        }

        private void UserSignin_Click(object sender, EventArgs e)
        {
            readerSignIn r = new readerSignIn();
            this.Hide();
            r.Show();
        }
    }
}
