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
    public partial class READER_Joind : Form
    {
        public READER_Joind()
        {
            InitializeComponent();
            ShowMan();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MARO;Initial Catalog=library;Integrated Security=True   ");

        private void BOOKSEARCH_Click(object sender, EventArgs e)
        {
            if (BOOKNAME.Text == "")
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
                    }*/




                    SqlCommand cmd = new SqlCommand("select BOOKID,NAME,AUTHOR,CATEGORY,NO_REMAINING FROM BOOK WHERE NAME LIKE '%@BN%'", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    /*cmd.Parameters.AddWithValue("@ID", res + 1);
                    cmd.Parameters.AddWithValue("@SS", READERSSN.Text);
                    cmd.Parameters.AddWithValue("@DB", BORROWDATE.Value.Date);
                    cmd.Parameters.AddWithValue("@DR", BORROWDATE.Value.Date.AddDays(5));*/
                    cmd.Parameters.AddWithValue("@BN", BOOKNAME.Text);
                    //cmd.Parameters.AddWithValue("@NO", );
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Order Added");
                    Con.Close();
                    Showsearched(BOOKNAME.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ShowMan()
        {
            Con.Open();
            String Query = "select BOOKID,NAME,AUTHOR,CATEGORY,NO_REMAINING FROM BOOK";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookTable.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Showsearched(string BOOKNAME)
        {
            Con.Open();
            String Query = "select BOOKID,NAME,AUTHOR,CATEGORY,NO_REMAINING FROM BOOK WHERE NAME LIKE '%@BN%'";
            SqlDataAdapter sda = new SqlDataAdapter(Query.Replace("@BN",BOOKNAME), Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookTable.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Reader_MyOrder r = new Reader_MyOrder();
            this.Hide();
            r.Show();
        }
    }
}
