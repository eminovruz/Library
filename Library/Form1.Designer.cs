namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.author_cmbx = new System.Windows.Forms.ComboBox();
            this.book_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookinfo_listbox = new System.Windows.Forms.ListBox();
            this.execute_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // author_cmbx
            // 
            this.author_cmbx.FormattingEnabled = true;
            this.author_cmbx.Location = new System.Drawing.Point(46, 54);
            this.author_cmbx.Name = "author_cmbx";
            this.author_cmbx.Size = new System.Drawing.Size(188, 28);
            this.author_cmbx.TabIndex = 0;
            this.author_cmbx.SelectedIndexChanged += new System.EventHandler(this.author_cmbx_SelectedIndexChanged);
            // 
            // book_cmbx
            // 
            this.book_cmbx.FormattingEnabled = true;
            this.book_cmbx.Location = new System.Drawing.Point(770, 54);
            this.book_cmbx.Name = "book_cmbx";
            this.book_cmbx.Size = new System.Drawing.Size(188, 28);
            this.book_cmbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(809, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // bookinfo_listbox
            // 
            this.bookinfo_listbox.FormattingEnabled = true;
            this.bookinfo_listbox.ItemHeight = 20;
            this.bookinfo_listbox.Location = new System.Drawing.Point(46, 95);
            this.bookinfo_listbox.Name = "bookinfo_listbox";
            this.bookinfo_listbox.Size = new System.Drawing.Size(912, 504);
            this.bookinfo_listbox.TabIndex = 4;
            // 
            // execute_btn
            // 
            this.execute_btn.Location = new System.Drawing.Point(451, 53);
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.Size = new System.Drawing.Size(94, 29);
            this.execute_btn.TabIndex = 5;
            this.execute_btn.Text = "Execute";
            this.execute_btn.UseVisualStyleBackColor = true;
            this.execute_btn.Click += new System.EventHandler(this.execute_btn_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(419, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(528, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1060, 641);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.execute_btn);
            this.Controls.Add(this.bookinfo_listbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book_cmbx);
            this.Controls.Add(this.author_cmbx);
            this.Name = "Form1";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox author_cmbx;
        private ComboBox book_cmbx;
        private Label label1;
        private Label label2;
        private ListBox bookinfo_listbox;
        private Button execute_btn;
        private Button button1;
        private Button button2;
    }
}