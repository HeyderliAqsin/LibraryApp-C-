using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void btnauthorname_Click(object sender, EventArgs e)
        {
            string authorname = txtAuthor.Text;
            if (!string.IsNullOrWhiteSpace(authorname))
            {
                string conText = "Data Source=DESKTOP-71GT86U; Initial Catalog=LibraryNewDB; integrated security=true";
                SqlConnection con = new SqlConnection(conText);
                string myCom = $"Insert into Authors Values(N'{authorname}')";
                con.Open();
                SqlCommand com = new SqlCommand(myCom, con);
                com.ExecuteNonQuery();
                con.Close();
                lblError.Visible = false;
                txtAuthor.Text = "";
                MessageBox.Show("Author added successfully!");
            }
            else
            {
                lblError.Text = "Author`s name have to fill";
                lblError.Visible = true;
            }
        }

    }
}
