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
namespace library
{
    public partial class ReaderSignUP : Form
    {
        public ReaderSignUP()
        {
            InitializeComponent();
        }

        private void AdminIdREGEST_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=MARO;Initial Catalog=library;Integrated Security=True   ");
        private void ADMINREGIST_Click(object sender, EventArgs e)
        {
            if (AdminIdREGEST.Text == "" || AdminName.Text == "" || Password_Regist_Admin.Text == "" || AdminPhone.Text == "" || AdminADDRESS.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    /*SqlCommand cm = new SqlCommand("SELECT MAX(BOOKID) from BOOK", Con);
                    int res = (int)cm.ExecuteScalar();*/
                    SqlCommand cmd = new SqlCommand("insert into READER(SSN,NAME,PHONE,BIRTHDATE,ADDRESS,PASSWORD)values(@ID,@NA,@PH,@BD,@AD,@PW)", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@ID", AdminIdREGEST.Text);
                    cmd.Parameters.AddWithValue("@NA", AdminName.Text);
                    cmd.Parameters.AddWithValue("@PH", AdminPhone.Text);
                    cmd.Parameters.AddWithValue("@BD", lIBRIRANBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@AD", AdminADDRESS.Text);
                    cmd.Parameters.AddWithValue("@PW", Password_Regist_Admin.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("READER ADDED");
                    choose r = new choose();
                    this.Hide();
                    r.Show();
                    Con.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
