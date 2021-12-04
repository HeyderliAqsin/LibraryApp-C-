using LibraryApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class ReaderGetBookForm : Form
    {
        LibraryNewDBContext db = new LibraryNewDBContext();
        public ReaderGetBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string readerName = txtreadername.Text;
            string bookname = cmbBooks.Text;
            DateTime getbook = cmbgetDate.Value;
            DateTime returnDate = cmbReturnDate.Value;
            if (utility.IsEmpty(new string[] {readerName,bookname}))
            {
                if (getbook < returnDate)
                {
                    Reader read = new Reader();
                    read.Fullname = readerName;
                    db.Readers.Add(read);
                    db.SaveChanges();
                    int bookid = db.Books.FirstOrDefault(x => x.Name == bookname).BookId;
                    ReaderToBook rtb = new ReaderToBook();
                    rtb.ReaderId = read.ReaderId;
                    rtb.BookId = bookid;
                    rtb.GetBookDate = getbook;
                    rtb.ReturnBookDate = returnDate;
                    db.ReaderToBooks.Add(rtb);
                    db.SaveChanges();
                    MessageBox.Show("Reader got Book");
                    FillDateGrid();
                }
                
            }

        }

        private void FillDateGrid()
        {
            dtgGrid.DataSource = db.ReaderToBooks.Select(x => new
            {
                BookName=x.Book.Name,
                ReaderName=x.Reader.Fullname,
                ExpireDate=( x.ReturnBookDate - x.GetBookDate).Days +" day"

            }).ToList();
        }

        private void ReaderGetBookForm_Load(object sender, EventArgs e)
        {
            FillDateGrid();
            FillBookCombo();
        }

        private void FillBookCombo()
        {
            cmbBooks.Items.AddRange(db.Books.Select(x => x.Name).ToArray());
        }

    }
}
