
namespace LibraryApp
{
    partial class ReaderGetBookForm
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
            this.btnGetBook = new System.Windows.Forms.Button();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.pbDate = new System.Windows.Forms.Label();
            this.cmbgetDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtreadername = new System.Windows.Forms.TextBox();
            this.readername = new System.Windows.Forms.Label();
            this.cmbReturnDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.Label();
            this.dtgGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetBook
            // 
            this.btnGetBook.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGetBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetBook.Location = new System.Drawing.Point(14, 470);
            this.btnGetBook.Name = "btnGetBook";
            this.btnGetBook.Size = new System.Drawing.Size(224, 59);
            this.btnGetBook.TabIndex = 13;
            this.btnGetBook.Text = "Get Reader Book";
            this.btnGetBook.UseVisualStyleBackColor = false;
            this.btnGetBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // cmbBooks
            // 
            this.cmbBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(14, 183);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(335, 36);
            this.cmbBooks.TabIndex = 12;
            // 
            // pbDate
            // 
            this.pbDate.AutoSize = true;
            this.pbDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pbDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.pbDate.Location = new System.Drawing.Point(14, 133);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(69, 28);
            this.pbDate.TabIndex = 11;
            this.pbDate.Text = "Books";
            // 
            // cmbgetDate
            // 
            this.cmbgetDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbgetDate.Location = new System.Drawing.Point(14, 284);
            this.cmbgetDate.Name = "cmbgetDate";
            this.cmbgetDate.Size = new System.Drawing.Size(333, 34);
            this.cmbgetDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(14, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Get Date";
            // 
            // txtreadername
            // 
            this.txtreadername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtreadername.Location = new System.Drawing.Point(13, 79);
            this.txtreadername.Name = "txtreadername";
            this.txtreadername.Size = new System.Drawing.Size(334, 34);
            this.txtreadername.TabIndex = 8;
            // 
            // readername
            // 
            this.readername.AutoSize = true;
            this.readername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.readername.ForeColor = System.Drawing.Color.SeaGreen;
            this.readername.Location = new System.Drawing.Point(12, 34);
            this.readername.Name = "readername";
            this.readername.Size = new System.Drawing.Size(140, 28);
            this.readername.TabIndex = 7;
            this.readername.Text = "Reader Name";
            // 
            // cmbReturnDate
            // 
            this.cmbReturnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbReturnDate.Location = new System.Drawing.Point(14, 386);
            this.cmbReturnDate.Name = "cmbReturnDate";
            this.cmbReturnDate.Size = new System.Drawing.Size(333, 34);
            this.cmbReturnDate.TabIndex = 15;
            // 
            // returnDate
            // 
            this.returnDate.AutoSize = true;
            this.returnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.returnDate.Location = new System.Drawing.Point(14, 342);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(127, 28);
            this.returnDate.TabIndex = 14;
            this.returnDate.Text = "Return Date";
            // 
            // dtgGrid
            // 
            this.dtgGrid.AllowUserToAddRows = false;
            this.dtgGrid.AllowUserToDeleteRows = false;
            this.dtgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrid.Location = new System.Drawing.Point(401, 24);
            this.dtgGrid.Name = "dtgGrid";
            this.dtgGrid.ReadOnly = true;
            this.dtgGrid.RowHeadersWidth = 51;
            this.dtgGrid.RowTemplate.Height = 29;
            this.dtgGrid.Size = new System.Drawing.Size(388, 549);
            this.dtgGrid.TabIndex = 16;
            // 
            // ReaderGetBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 596);
            this.Controls.Add(this.dtgGrid);
            this.Controls.Add(this.cmbReturnDate);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.btnGetBook);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.pbDate);
            this.Controls.Add(this.cmbgetDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtreadername);
            this.Controls.Add(this.readername);
            this.Name = "ReaderGetBookForm";
            this.Text = "ReaderGetBookForm";
            this.Load += new System.EventHandler(this.ReaderGetBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetBook;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label pbDate;
        private System.Windows.Forms.DateTimePicker cmbgetDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreadername;
        private System.Windows.Forms.Label readername;
        private System.Windows.Forms.DateTimePicker cmbReturnDate;
        private System.Windows.Forms.Label returnDate;
        private System.Windows.Forms.DataGridView dtgGrid;
    }
}