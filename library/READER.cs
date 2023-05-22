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
    public partial class READER : Form
    {
        public READER()
        {
            InitializeComponent();
            ShowMan();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=MARO;Initial Catalog=library;Integrated Security=True   ");

        private void ShowMan()
        {
            Con.Open();
            String Query = "select * FROM READER";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReaderGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void READER_ADD_Click(object sender, EventArgs e)
        {
            if (ReaderName.Text == "" || ReaderPhone.Text == "" || ReadderAddress.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cm = new SqlCommand("SELECT MAX(BOOKID) from BOOK", Con);
                    int res = (int)cm.ExecuteScalar();
                    SqlCommand cmd = new SqlCommand("insert into READER(SSN,NAME,PHONE,BIRTHDATE,ADDRESS)values(@SS,@NA,@PH,@BD,@AD)", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@SS", ReaderSSN.Text);
                    cmd.Parameters.AddWithValue("@NA", ReaderName.Text);
                    cmd.Parameters.AddWithValue("@PH", ReaderPhone.Text);
                    cmd.Parameters.AddWithValue("@BD", ReaderBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@AD", ReadderAddress.Text);
                    //cmd.Parameters.AddWithValue("@NO", );
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reader Added");
                    Con.Close();
                    ShowMan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        string Key ="";

        private void ReaderEdit_Click(object sender, EventArgs e)
        {
            if (ReaderName.Text == "" || ReaderSSN.Text == "" || ReaderPhone.Text == "" || ReadderAddress.Text == "" )
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
                    SqlCommand cmd = new SqlCommand("update READER set SSN = @SS,NAME = @NA,PHONE = @PH,BIRTHDATE = @BD,ADDRESS = @AD where SSN = @Mkey", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    //cmd.Parameters.AddWithValue("@ID", res + 1);
                    cmd.Parameters.AddWithValue("@SS", ReaderSSN.Text);
                    cmd.Parameters.AddWithValue("@NA", ReaderName.Text);
                    cmd.Parameters.AddWithValue("@PH", ReaderPhone.Text);
                    cmd.Parameters.AddWithValue("@BD", ReaderBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@AD", ReadderAddress.Text);
                    cmd.Parameters.AddWithValue("@Mkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reader Updated");
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

        private void ReaderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            ReaderSSN.Text = ReaderGrid.SelectedRows[0].Cells[0].Value.ToString();
            ReaderName.Text = ReaderGrid.SelectedRows[0].Cells[1].Value.ToString();
            ReaderPhone.Text = ReaderGrid.SelectedRows[0].Cells[2].Value.ToString();
            ReaderBirth.Value = Convert.ToDateTime(ReaderGrid.SelectedRows[0].Cells[3].Value.ToString());
            ReadderAddress.Text = ReaderGrid.SelectedRows[0].Cells[4].Value.ToString();
           
            if (ReaderName.Text == "")
              {
                  Key = "";
              }
              else
              {
                  Key = ReaderGrid.SelectedRows[0].Cells[0].Value.ToString();
              }
        }

        private void ReaderDelete_Click(object sender, EventArgs e)
        {
            if (Key == "")
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
                    SqlCommand cmd = new SqlCommand("delete from READER where SSN = @Mkey", Con);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter, 1, "@BC", BOOKCATEGORY, "@BA", BOOKADD, "@BN", BOOKNAME, "@BR", BOOKINSTOCK);
                    //cmd.Parameters.AddWithValue("@global.counter", global.counter);
                    cmd.Parameters.AddWithValue("@Mkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("READER Deleted");
                    Con.Close();
                    ShowMan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label_Reader_Click(object sender, EventArgs e)
        {
            
        }

        private void books_l_Click(object sender, EventArgs e)
        {
            books_tab b = new books_tab();
            b.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            order o = new order();
            o.Show();
            this.Hide();
        }
    }
}
