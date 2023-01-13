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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(1012, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(451, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(978, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "FirstName";
            this.textBox1.Size = new System.Drawing.Size(345, 27);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(978, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "LastName";
            this.textBox2.Size = new System.Drawing.Size(345, 27);
            this.textBox2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(1175, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "delete author";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Location = new System.Drawing.Point(240, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1335, 644);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.PerformLayout();

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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
    }
}