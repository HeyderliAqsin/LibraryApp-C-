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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm bk = new AddBookForm();
            bk.ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AuthorForm af = new AuthorForm();
            af.ShowDialog();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReaderGetBookForm rdgbook = new ReaderGetBookForm();
            rdgbook.ShowDialog();
        }
    }
}
