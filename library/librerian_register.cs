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
    public partial class librerian_register : Form
    {
        public librerian_register()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MARO;Initial Catalog=library;Integrated Security=True   ");
        private void ADMINREGIST_Click(object sender, EventArgs e)
        {
            if ( AdminName.Text == "" || Password_Regist_Admin.Text == "" || AdminPhone.Text == "" || AdminADDRESS.Text == "")
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
                    int res;
                    SqlCommand cm = new SqlCommand("SELECT MAX(ID) from LIBRARIAN", Con);
                    var flag = cm.ExecuteScalar();
                    if (flag != DBNull.Value)
                    {
                        res = (int)cm.ExecuteScalar();
                    }
                    else
                    {
                        res = 0;
                    }
                    SqlCommand cmd = new SqlCommand("insert into LIBRARIAN(ID,NAME,PHONE,BIRTHDATE,ADDRESS,PASSWORD)values(@ID,@NA,@PH,@BD,@AD,@PW)", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@ID", res + 1);
                    cmd.Parameters.AddWithValue("@NA", AdminName.Text);
                    cmd.Parameters.AddWithValue("@PH", AdminPhone.Text);
                    cmd.Parameters.AddWithValue("@BD", lIBRIRANBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@AD", AdminADDRESS.Text);
                    cmd.Parameters.AddWithValue("@PW", Password_Regist_Admin.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("LIBRARIAN ADDED");
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
