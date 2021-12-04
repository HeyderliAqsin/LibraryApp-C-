using LibraryApp.Model;
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
    public partial class AddBookForm : Form
    {
        LibraryNewDBContext db = new LibraryNewDBContext();
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            FillAuthorCombo();
            FillBookGridView();
        }

        public void FillBookGridView()
        {
            //string conText = "Data Source=DESKTOP-71GT86U; Initial Catalog= LibraryNewDB; integrated security=true";
            //SqlConnection con = new SqlConnection(conText);
            //string myCom = "select * from BookWithAuthors";
            //SqlDataAdapter dataadapter = new SqlDataAdapter(myCom, con);
            //DataSet ds = new DataSet();
            //con.Open();
            //dataadapter.Fill(ds, "Books");
            //con.Close();
            //dtgBookList.DataSource = ds;
            //dtgBookList.DataMember = "Books";

            dtgBookList.DataSource = db.BookWithAuthors.ToList();
        }
        public void FillAuthorCombo()
        {
            //string conText = "Data Source=DESKTOP-71GT86U; Initial Catalog= LibraryNewDB; integrated security=true";
            //SqlConnection con = new SqlConnection(conText);
            //con.Open();
            //string myCom = "select Name from Authors";
            //SqlCommand com = new SqlCommand(myCom, con);
            //var res = com.ExecuteReader();
            //while (res.Read())
            //{
            //    cmbAuthors.Items.Add(res["Name"].ToString());

            //}
            //con.Close();
            cmbAuthors.Items.AddRange(db.Authors.Select(x => x.Name).ToArray());
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string bookname = textBookName.Text;
            DateTime publishD = publishDate.Value;
            string authorname = cmbAuthors.Text;
            //string conText = "Data Source=DESKTOP-71GT86U; Initial Catalog= LibraryNewDB; integrated security=true";
            //SqlConnection con = new SqlConnection(conText); 
            //con.Open();
            //string findAuthorId = $"select AuthorId from Authors where Name=N'{authorname}'";
            //int authorId = 0;
            //SqlCommand com = new SqlCommand(findAuthorId, con);
            //var res=com.ExecuteReader();
            //while (res.Read())
            //{
            //    authorId =Convert.ToInt32(res["AuthorId"].ToString());
            //}
            //MessageBox.Show(authorId.ToString());
            //con.Close();

            //SqlConnection con2 = new SqlConnection(conText);
            //con2.Open();
            //string comQuery = $"insert into Books Values(N'{bookname}','{publishD}',{authorId})";
            //SqlCommand com2 = new SqlCommand(comQuery,con2);
            //var resBook = com2.ExecuteNonQuery();
            //con2.Close();

            if (!string.IsNullOrWhiteSpace(bookname) && !string.IsNullOrWhiteSpace(authorname)) {
                int authorId = db.Authors.FirstOrDefault(x => x.Name == authorname).AuthorId;

                Book newBook = new Book()
                {
                    Name = bookname,
                    PublishDate = publishD,
                    AuthorId = authorId
                };
                db.Books.Add(newBook);
                db.SaveChanges();

                MessageBox.Show("Book added successfully");
                FillBookGridView();
            }
            else
            {
                MessageBox.Show("Please All the fill!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
    }
}
