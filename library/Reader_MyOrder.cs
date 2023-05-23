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
    public partial class Reader_MyOrder : Form
    {
        public Reader_MyOrder()
        {
            InitializeComponent();
            ShowMan(readerSignIn.ssn);
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MARO;Initial Catalog=library;Integrated Security=True   ");
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void ShowMan(string ssn)
        {
            Con.Open();
            String Query = "select * FROM BORROWING where SSN=@SSN";
            SqlDataAdapter sda = new SqlDataAdapter(Query.Replace("@SSN",ssn), Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MyordersTable.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void books_l_Click(object sender, EventArgs e)
        {
            READER_Joind r = new READER_Joind();
            this.Hide();
            r.Show();
        }
    }
}
