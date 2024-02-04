namespace FileIODemo
{
    partial class Form1
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
            this.lblid = new System.Windows.Forms.Label();
            this.btnwrite = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.btnread = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btncreatedirectory = new System.Windows.Forms.Button();
            this.btnstreamwrite = new System.Windows.Forms.Button();
            this.btnstreamread = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(103, 47);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 16);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id";
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(46, 214);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 23);
            this.btnwrite.TabIndex = 1;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(191, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(191, 87);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 4;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(103, 93);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(191, 139);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(100, 22);
            this.txtsalary.TabIndex = 6;
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(103, 145);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(46, 16);
            this.lblsalary.TabIndex = 5;
            this.lblsalary.Text = "Salary";
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(237, 214);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 7;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(326, 86);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(120, 23);
            this.btncreatefile.TabIndex = 8;
            this.btncreatefile.Text = "Create File";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // btncreatedirectory
            // 
            this.btncreatedirectory.Location = new System.Drawing.Point(326, 41);
            this.btncreatedirectory.Name = "btncreatedirectory";
            this.btncreatedirectory.Size = new System.Drawing.Size(120, 23);
            this.btncreatedirectory.TabIndex = 9;
            this.btncreatedirectory.Text = "Create Directory";
            this.btncreatedirectory.UseVisualStyleBackColor = true;
            this.btncreatedirectory.Click += new System.EventHandler(this.btncreatedirectory_Click);
            // 
            // btnstreamwrite
            // 
            this.btnstreamwrite.Location = new System.Drawing.Point(446, 244);
            this.btnstreamwrite.Name = "btnstreamwrite";
            this.btnstreamwrite.Size = new System.Drawing.Size(126, 23);
            this.btnstreamwrite.TabIndex = 10;
            this.btnstreamwrite.Text = "Stream Write";
            this.btnstreamwrite.UseVisualStyleBackColor = true;
            this.btnstreamwrite.Click += new System.EventHandler(this.btnstreamwrite_Click);
            // 
            // btnstreamread
            // 
            this.btnstreamread.Location = new System.Drawing.Point(647, 244);
            this.btnstreamread.Name = "btnstreamread";
            this.btnstreamread.Size = new System.Drawing.Size(129, 23);
            this.btnstreamread.TabIndex = 11;
            this.btnstreamread.Text = "Stream Read";
            this.btnstreamread.UseVisualStyleBackColor = true;
            this.btnstreamread.Click += new System.EventHandler(this.btnstreamread_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(488, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 173);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnstreamread);
            this.Controls.Add(this.btnstreamwrite);
            this.Controls.Add(this.btncreatedirectory);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.lblid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btncreatedirectory;
        private System.Windows.Forms.Button btnstreamwrite;
        private System.Windows.Forms.Button btnstreamread;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

