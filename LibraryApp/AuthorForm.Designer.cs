
namespace LibraryApp
{
    partial class AuthorForm
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
            this.btnauthorname = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtauthorname = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnauthorname
            // 
            this.btnauthorname.BackColor = System.Drawing.Color.DarkGreen;
            this.btnauthorname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnauthorname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnauthorname.Location = new System.Drawing.Point(53, 135);
            this.btnauthorname.Name = "btnauthorname";
            this.btnauthorname.Size = new System.Drawing.Size(153, 49);
            this.btnauthorname.TabIndex = 13;
            this.btnauthorname.Text = "Add Author";
            this.btnauthorname.UseVisualStyleBackColor = false;
            this.btnauthorname.Click += new System.EventHandler(this.btnauthorname_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthor.Location = new System.Drawing.Point(53, 78);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(251, 34);
            this.txtAuthor.TabIndex = 8;
            // 
            // txtauthorname
            // 
            this.txtauthorname.AutoSize = true;
            this.txtauthorname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtauthorname.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtauthorname.Location = new System.Drawing.Point(53, 34);
            this.txtauthorname.Name = "txtauthorname";
            this.txtauthorname.Size = new System.Drawing.Size(140, 28);
            this.txtauthorname.TabIndex = 7;
            this.txtauthorname.Text = "Author Name";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.DeepPink;
            this.lblError.Location = new System.Drawing.Point(53, 216);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(140, 28);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "Author Name";
            this.lblError.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(805, 306);
            this.dataGridView1.TabIndex = 16;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnauthorname);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtauthorname);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnauthorname;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label txtauthorname;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}