
namespace LibraryApp
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbookname = new System.Windows.Forms.Label();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publishDate = new System.Windows.Forms.DateTimePicker();
            this.pbDate = new System.Windows.Forms.Label();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dtgBookList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbookname
            // 
            this.txtbookname.AutoSize = true;
            this.txtbookname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbookname.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtbookname.Location = new System.Drawing.Point(12, 28);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(122, 28);
            this.txtbookname.TabIndex = 0;
            this.txtbookname.Text = "Book Name";
            // 
            // textBookName
            // 
            this.textBookName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBookName.Location = new System.Drawing.Point(13, 73);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(334, 34);
            this.textBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(13, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Publish Date";
            // 
            // publishDate
            // 
            this.publishDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishDate.Location = new System.Drawing.Point(14, 169);
            this.publishDate.Name = "publishDate";
            this.publishDate.Size = new System.Drawing.Size(333, 34);
            this.publishDate.TabIndex = 3;
            // 
            // pbDate
            // 
            this.pbDate.AutoSize = true;
            this.pbDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pbDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.pbDate.Location = new System.Drawing.Point(13, 228);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(87, 28);
            this.pbDate.TabIndex = 4;
            this.pbDate.Text = "Authors";
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(12, 265);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(335, 36);
            this.cmbAuthors.TabIndex = 5;
            this.cmbAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddBook.Location = new System.Drawing.Point(14, 345);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(224, 59);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dtgBookList
            // 
            this.dtgBookList.AllowUserToAddRows = false;
            this.dtgBookList.AllowUserToDeleteRows = false;
            this.dtgBookList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBookList.Location = new System.Drawing.Point(379, 31);
            this.dtgBookList.Name = "dtgBookList";
            this.dtgBookList.ReadOnly = true;
            this.dtgBookList.RowHeadersWidth = 51;
            this.dtgBookList.RowTemplate.Height = 29;
            this.dtgBookList.Size = new System.Drawing.Size(494, 407);
            this.dtgBookList.TabIndex = 7;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.dtgBookList);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.pbDate);
            this.Controls.Add(this.publishDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBookName);
            this.Controls.Add(this.txtbookname);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtbookname;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker publishDate;
        private System.Windows.Forms.Label pbDate;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dtgBookList;
    }
}