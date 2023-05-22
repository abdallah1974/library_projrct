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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            ShowMan();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MARO;Initial Catalog=library;Integrated Security=True   ");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void l_Name_Click(object sender, EventArgs e)
        {

        }

        private void ReaderBirth_onValueChanged(object sender, EventArgs e)
        {

        }
        private void ShowMan()
        {
            Con.Open();
            String Query = "select * FROM BORROWING";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrderGrid.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ReaderDelete_Click(object sender, EventArgs e)
        {
            
        }
    
        int Key = 0;
        private void ReaderEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void ReaderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void READER_ADD_Click(object sender, EventArgs e)
        {
            
        }

        private void ReaderSSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ReaderName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ReaderPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadderAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ORDER_ADD_Click(object sender, EventArgs e)
        {
            if (READERSSN.Text == "" || BOOKNAME.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    int res;  
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
                    
                    
                   
                    
                    SqlCommand cmd = new SqlCommand("insert into BORROWING(BOR_ID,SSN,DATEOFBOR_,DATEOFRET_,BOOKNAME)values(@ID,@SS,@DB,@DR,@BN)", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@ID", res + 1);
                    cmd.Parameters.AddWithValue("@SS", READERSSN.Text);
                    cmd.Parameters.AddWithValue("@DB", BORROWDATE.Value.Date);
                    cmd.Parameters.AddWithValue("@DR", BORROWDATE.Value.Date.AddDays(5));
                    cmd.Parameters.AddWithValue("@BN", BOOKNAME.Text);
                    //cmd.Parameters.AddWithValue("@NO", );
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added");
                    Con.Close();
                    ShowMan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            READERSSN.Text = OrderGrid.SelectedRows[0].Cells[1].Value.ToString();
            BOOKNAME.Text = OrderGrid.SelectedRows[0].Cells[4].Value.ToString();
            // BORROWDATE.Text = ReaderGrid.SelectedRows[0].Cells[2].Value.ToString();
            BORROWDATE.Value = Convert.ToDateTime(OrderGrid.SelectedRows[0].Cells[2].Value.ToString());
            // ReadderAddress.Text = ReaderGrid.SelectedRows[0].Cells[4].Value.ToString();

            if (READERSSN.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(OrderGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void OrderEdit_Click(object sender, EventArgs e)
        {
            if (READERSSN.Text == "" || BOOKNAME.Text == "")
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
                    SqlCommand cmd = new SqlCommand("update BORROWING set SSN = @SS,BOOKNAME = @BN,DATEOFBOR_ = @DB,DATEOFret_ = @DR where BOR_ID = @Mkey", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    //cmd.Parameters.AddWithValue("@ID", res + 1);
                    cmd.Parameters.AddWithValue("@SS", READERSSN.Text);
                    cmd.Parameters.AddWithValue("@BN", BOOKNAME.Text);
                    cmd.Parameters.AddWithValue("@DB", BORROWDATE.Value.Date);
                    cmd.Parameters.AddWithValue("@DR", BORROWDATE.Value.Date.AddDays(5));

                    cmd.Parameters.AddWithValue("@Mkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Updated");
                    //global.counter++;
                    Con.Close();
                    ShowMan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OrderDelete_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from BORROWING where BOR_ID = @Mkey", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@Mkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Deleted");
                    Con.Close();
                    ShowMan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void books_l_Click(object sender, EventArgs e)
        {
            books_tab b = new books_tab();
            b.Show();
            this.Hide();
        }

        private void label_Reader_Click(object sender, EventArgs e)
        {
            READER b = new READER();
            b.Show();
            this.Hide();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }
    }
}
