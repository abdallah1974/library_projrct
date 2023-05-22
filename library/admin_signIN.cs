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
    public partial class admin_signIN : Form
    {
        public admin_signIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=MARO;Initial Catalog=library;Integrated Security=True   ");
        private void LoginSignin_Click(object sender, EventArgs e)
        {
            if (IDLogin.Text == "" || PasswordLogin_ADMIN.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    /*int res;
                    SqlCommand cm = new SqlCommand("SELECT MAX(BOR_ID) from BORROWING", Con);
                    var flag = cm.ExecuteScalar();
                    if (flag != DBNull.Value)
                    {
                        res = (int)cm.ExecuteScalar();
                    }
                    else
                    {
                        res = 0;
                    }


                    */

                    SqlCommand cmd = new SqlCommand("SELECT PASSWORD FROM LIBRARIAN WHERE ID = @ID", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@ID", IDLogin.Text);
                    /*cmd.Parameters.AddWithValue("@SS", READERSSN.Text);
                    cmd.Parameters.AddWithValue("@DB", BORROWDATE.Value.Date);
                    cmd.Parameters.AddWithValue("@DR", BORROWDATE.Value.Date.AddDays(5));
                    cmd.Parameters.AddWithValue("@BN", BOOKNAME.Text);*/
                    //cmd.Parameters.AddWithValue("@NO", );
                    if (PasswordLogin_ADMIN.Text == (string)cmd.ExecuteScalar())
                    {
                        MessageBox.Show("LOGED-IN");
                        //this.Hide();
                        books_tab b = new books_tab();
                        b.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong input");
                    }
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Order Added");
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
