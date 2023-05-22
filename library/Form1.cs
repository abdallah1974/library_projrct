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
    public partial class books_tab : Form
    {
        public books_tab()
        {
            InitializeComponent();
            ShowMan();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            READER b = new READER();
            b.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=MARO;Initial Catalog=library;Integrated Security=True   ");

        class global
        {
            public static int counter = 2;
        }
        private void ShowMan()
        {
            Con.Open();
            String Query = "select BOOKID, NAME, AUTHOR, CATEGORY, NO_REMAINING from BOOK ORDER BY BOOKID";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookTable.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void BOOKADD_Click(object sender, EventArgs e)
        {
            if (BOOKNAME.Text == ""  || BOOKAUTHOR.Text == ""  || BOOKINSTOCK.Text == ""){
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cm = new SqlCommand("SELECT MAX(BOOKID) from BOOK",Con);
                    int res = (int)cm.ExecuteScalar();
                    SqlCommand cmd = new SqlCommand("insert into BOOK(BOOKID,ID,CATEGORY,AUTHOR,NAME,NO_REMAINING)values(@ID,@i,@BC,@BA,@BN,@BR)", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@ID", res+1);
                    cmd.Parameters.AddWithValue("@i", 1);
                    cmd.Parameters.AddWithValue("@BC", BOOKCATEGORY.SelectedItem);
                    cmd.Parameters.AddWithValue("@BA", BOOKAUTHOR.Text);
                    cmd.Parameters.AddWithValue("@BN", BOOKNAME.Text);
                    cmd.Parameters.AddWithValue("@BR", BOOKINSTOCK.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Added");
                    global.counter++;
                    Con.Close();
                    ShowMan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void BookTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            BOOKNAME.Text = BookTable.SelectedRows[0].Cells[1].Value.ToString();
            BOOKAUTHOR.Text = BookTable.SelectedRows[0].Cells[2].Value.ToString();
            BOOKINSTOCK.Text = BookTable.SelectedRows[0].Cells[4].Value.ToString();
            BOOKCATEGORY.SelectedItem = BookTable.SelectedRows[0].Cells[3].Value.ToString();
            if (BOOKNAME.Text == "") {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BookTable.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BOOKDELETE_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Book");
            }
            else
            {
                try
                {
                    Con.Open();
                    /*SqlCommand cm = new SqlCommand("SELECT count(*) from BOOK", Con);
                    int res = (int)cm.ExecuteScalar();*/
                    SqlCommand cmd = new SqlCommand("delete from BOOK where BOOKID = @Mkey", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@Mkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted");
                    Con.Close();
                    ShowMan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BOOKEDIT_Click(object sender, EventArgs e)
        {
            if (BOOKNAME.Text == "" || BOOKAUTHOR.Text == "" || BOOKINSTOCK.Text == "")
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
                    SqlCommand cmd = new SqlCommand("update BOOK set ID = @i, CATEGORY = @BC,AUTHOR = @BA,NAME = @BN,NO_REMAINING =@BR where BOOKID = @Mkey", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    //cmd.Parameters.AddWithValue("@ID", res + 1);
                    cmd.Parameters.AddWithValue("@i", 1);
                    cmd.Parameters.AddWithValue("@BC", BOOKCATEGORY.SelectedItem);
                    cmd.Parameters.AddWithValue("@BA", BOOKAUTHOR.Text);
                    cmd.Parameters.AddWithValue("@BN", BOOKNAME.Text);
                    cmd.Parameters.AddWithValue("@BR", BOOKINSTOCK.Text);
                    cmd.Parameters.AddWithValue("@Mkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated");
                    global.counter++;
                    Con.Close();
                    ShowMan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            order b = new order();
            b.Show();
            this.Hide();
        }

        private void BOOKNAME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
