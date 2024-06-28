namespace View
{
    partial class FormBrowseBooks
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
            this.BrowseBooksListGrid = new System.Windows.Forms.DataGridView();
            this.browseBooksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBooksListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseBooksListGrid
            // 
            this.BrowseBooksListGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.BrowseBooksListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrowseBooksListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BrowseBooksListGrid.Location = new System.Drawing.Point(30, 97);
            this.BrowseBooksListGrid.Name = "BrowseBooksListGrid";
            this.BrowseBooksListGrid.RowHeadersWidth = 62;
            this.BrowseBooksListGrid.RowTemplate.Height = 28;
            this.BrowseBooksListGrid.Size = new System.Drawing.Size(573, 287);
            this.BrowseBooksListGrid.TabIndex = 0;
            this.BrowseBooksListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // browseBooksButton
            // 
            this.browseBooksButton.Location = new System.Drawing.Point(287, 29);
            this.browseBooksButton.Name = "browseBooksButton";
            this.browseBooksButton.Size = new System.Drawing.Size(182, 48);
            this.browseBooksButton.TabIndex = 1;
            this.browseBooksButton.Text = "Browse All Books";
            this.browseBooksButton.UseVisualStyleBackColor = true;
            this.browseBooksButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(503, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click the button to browse all the books";
            // 
            // FormBrowseBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseBooksButton);
            this.Controls.Add(this.BrowseBooksListGrid);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormBrowseBooks";
            this.Text = "AIT Library System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrowseBooksListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BrowseBooksListGrid;
        private System.Windows.Forms.Button browseBooksButton;
        private System.Windows.Forms.Label label1;
    }
}

